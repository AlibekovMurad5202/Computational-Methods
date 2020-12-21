using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLAE_Solver
{
    class CramerMethod : SLAESolvingMethod
    {
        public override double[] Solve(double[,] matrix, double[] b)
        {
            int length = matrix.GetLength(0);
            double[,] newMatrix = new double[length, length];
            Array.Copy(matrix, newMatrix, length * length);

            double detMatrix = Determinant(newMatrix);
            double[] x = new double[length];

            for (int i = 0; i < length; i++)
            {
                Array.Copy(matrix, newMatrix, length * length);
                for (int j = 0; j < length; j++)
                    newMatrix[j, i] = b[j];

                x[i] = Determinant(newMatrix) / detMatrix;
            }

            return x;
        }
    }
}
