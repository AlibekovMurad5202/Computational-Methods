using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLAE_Solver
{
    class SeidelMethod : SLAESolvingMethod
    {
        private readonly double eps;

        public SeidelMethod(double eps = 0.00001)
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

            do
            {
                Array.Copy(x, previous, length);

                for (int i = 0; i < length; i++)
                {
                    double var = 0.0;

                    for (int j = 0; j < i; j++)
                        var += matrix[i, j] * x[j];

                    for (int j = i + 1; j < length; j++)
                        var += matrix[i, j] * previous[j];

                    x[i] = (b[i] - var) / matrix[i, i];
                }

            } while (!Converge(ref x, ref previous));

            return x;
        }
    }
}
