using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLAE_Solver
{
    class SimpleIterationMethod : SLAESolvingMethod
    {
        private readonly double eps;

        public SimpleIterationMethod(double eps = 0.00001)
        {
            this.eps = eps;
        }

        private bool Converge(ref double[] x_k, ref double[] x_k_previous)
        {
            int length = x_k.GetLength(0);

            double norm = 0.0;
            for (int i = 0; i < length; i++)
                norm += (x_k[i] - x_k_previous[i]) * (x_k[i] - x_k_previous[i]);

            return Math.Sqrt(norm) < eps;
        }

        public override double[] Solve(double[,] matrix, double[] b)
        {
            int length = matrix.GetLength(0);
            double[] previous = new double[length];
            double[] x = new double[length];

            double[,] alpha = new double[length, length];
            double[] beta = new double[length];

            for (int i = 0; i < length; i++)
            {
                beta[i] = b[i] / matrix[i, i];

                for (int j = 0; j < length; j++)
                    alpha[i, j] = (i == j) ? 0 : -matrix[i, j] / matrix[i, i];
            }

            Array.Copy(beta, x, length);

            do
            {
                Array.Copy(x, previous, length);

                for (int i = 0; i < length; i++)
                {
                    double[] c = new double[length];
                    for (int j = 0; j < length; j++)
                        c[i] += alpha[i, j] * previous[j];

                    x[i] = beta[i] + c[i];
                }

            } while (!Converge(ref x, ref previous));

            return x;
        }
    }
}
