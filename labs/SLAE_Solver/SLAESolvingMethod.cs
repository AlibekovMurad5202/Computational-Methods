using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLAE_Solver
{
    abstract class SLAESolvingMethod
    {
        public abstract double[] Solve(double[,] matrix, double[] b);

        public static bool IsDiagonalityDominance(ref double[,] matrix)
        {
            int length = matrix.GetLength(0);

            for (int i = 0; i < length; i++)
            {
                double sumNonDiagonalElems = 0.0;
                for (int j = 0; j < length; j++)
                {
                    if (i == j) continue;
                    else sumNonDiagonalElems += Math.Abs(matrix[i, j]);
                }

                if (Math.Abs(matrix[i, i]) <= sumNonDiagonalElems)
                    return false;
            }

            return true;
        }
        
        public static double Determinant(double[,] matrix)
        {
            int length = matrix.GetLength(0);
            double det = 1;

            const double EPS = 1E-9;
            for (int i = 0; i < length; i++)
            {
                int k = i;
                for (int j = i + 1; j < length; j++)
                    if (Math.Abs(matrix[j, i]) > Math.Abs(matrix[k, i]))
                        k = j;
                if (Math.Abs(matrix[k, i]) < EPS) { det = 0; break; }

                for (int j = 0; j < length; j++)
                {
                    double temp = matrix[i, j];
                    matrix[i, j] = matrix[k, j];
                    matrix[k, j] = temp;
                }

                if (i != k) det = -det;

                det *= matrix[i, i];

                for (int j = i + 1; j < length; j++)
                    matrix[i, j] /= matrix[i, i];

                for (int j = 0; j < length; j++)
                    if ((j != i) && (Math.Abs(matrix[j, i]) > EPS))
                        for (k = i + 1; k < length; k++)
                            matrix[j, k] -= matrix[i, k] * matrix[j, i];
            }

            return det;
        }

    }
}
