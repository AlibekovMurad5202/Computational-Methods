using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubic_Spline_Interpolation
{
    class CubicSpline
    {
        double[,] coeffs;

        public CubicSpline(int N)
        {
            this.coeffs = new double[N, 4];
        }

        public double this[int interval, int coeff_idx]
        {
            get { return coeffs[interval, coeff_idx]; }
            set { coeffs[interval, coeff_idx] = value; }
        }

        private double CalculateDividedDifferences(double[] X, double[] Y)
        {
            int n = X.Length;
            double result = 0;
            for (int j = 0; j < n; j++)
            {
                double denom = 1;
                for (int i = 0; i < n; i++)
                    if (i != j)
                        denom *= (X[j] - X[i]);
                result += Y[j] / denom;
            }
            return result;
        }

        public double[,] SetCoefficients(double[] X, double[] Y)
        {
            int n = X.Length - 1;
            this.coeffs = new double[n, 4];
            
            double[] h = new double[n];
            for (int i = 0; i < n; i++)
                h[i] = X[i + 1] - X[i];

            TridiagonalMatrix SLAE_coeffs = new TridiagonalMatrix(n - 1);
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - 1; j++)
                {
                    if (i == j)
                        SLAE_coeffs[i, j] = 2;
                    else if (i == j - 1)
                        SLAE_coeffs[i, j] = h[i + 1] / (h[i] + h[i + 1]);
                    else if (i == j + 1)
                        SLAE_coeffs[i, j] = h[i] / (h[i] + h[i + 1]);
                    else
                        SLAE_coeffs[i, j] = 0;
                }

            double[] F = new double[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                double[] x = { X[i], X[i + 1], X[i + 2] };
                double[] y = { Y[i], Y[i + 1], Y[i + 2] };
                F[i] = 3 * CalculateDividedDifferences(x, y);
            }

            double[] SLAE_solution = SLAE_coeffs.Solve_SLAE(F);
            double[] c = new double[n + 1];
            c[0] = c[n] = 0;
            for (int i = 1; i < n; i++)
                c[i] = SLAE_solution[i - 1];

            for (int i = 0; i < n; i++)
            {
                coeffs[i, 0] = Y[i];
                coeffs[i, 1] = (Y[i + 1] - Y[i]) / h[i] - (c[i + 1] + 2 * c[i]) * h[i] / 6;
                coeffs[i, 2] = c[i];
                coeffs[i, 3] = (c[i + 1] - c[i]) / h[i];
            }
        
            return coeffs;
        }
    }
}
