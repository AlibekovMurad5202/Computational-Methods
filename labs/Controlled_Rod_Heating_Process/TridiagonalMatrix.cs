using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controlled_Rod_Heating_Process
{
    public class TridiagonalMatrix
    {
        double[] A, B, C;

        public TridiagonalMatrix(int N)
        {
            this.A = new double[N];
            this.B = new double[N];
            this.C = new double[N];
        }

        public double this[int row, int column]
        {
            get
            {
                if (row == column)
                    return C[row];
                else if (row == column - 1)
                    return B[row];
                else if (row == column + 1)
                    return A[row];
                else return 0;
            }

            set
            {
                if (row == column)
                    C[row] = value;
                else if (row == column - 1)
                    B[row] = value;
                else if (row == column + 1)
                    A[row] = value;
            }
        }

        public double[] Solve_SLAE(double[] F)      // Ax = F
        {
            int n = C == null ? 0 : C.Length;

            if (n == 0)
                return new double[] { 0 };
            if (n == 1)
                return new double[] { F[0] / C[0] };

            double[] alpha = new double[n];
            double[] beta = new double[n];

            double y = C[0];
            alpha[0] = -B[0] / C[0]; // = -B[0] / y;
            beta[0] = F[0] / C[0];   // = F[0] / y;
            for (int i = 1; i < n - 1; i++)
            {
                y = C[i] + A[i] * alpha[i - 1];
                alpha[i] = -B[i] / y;
                beta[i] = (F[i] - A[i] * beta[i - 1]) / y;
            }
            y = C[n - 1] + A[n - 1] * alpha[(n - 1) - 1];
            beta[n - 1] = (F[n - 1] - A[n - 1] * beta[(n - 1) - 1]) / y;

            double[] x = new double[n];
            x[n - 1] = beta[n - 1];
            for (int i = (n - 1) - 1; i >= 0; i--)
                x[i] = alpha[i] * x[i + 1] + beta[i];
            return x;
        }
    }
}
