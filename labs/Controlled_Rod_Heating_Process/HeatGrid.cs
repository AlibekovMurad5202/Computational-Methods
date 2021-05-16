using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controlled_Rod_Heating_Process
{
    public class HeatGrid
    {
        public static double[,] CalcB(double L,
                              double T,
                              double h,
                              double tau,
                              Func<double, double> phi,
                              Func<double, double> b,
                              ref ProgressBar progressBar)
        {
            progressBar.Value = progressBar.Minimum;

            int x_steps_count = Convert.ToInt32(L / h) + 1;
            int t_steps_count = Convert.ToInt32(T / tau) + 1;
            double[,] grid = new double[x_steps_count, t_steps_count];

            for (int i = 0; i < x_steps_count; i++)
            {
                grid[i, 0] = phi(i * h);
            }

            TridiagonalMatrix SLAE = PrepareTridiagonalMatrix(x_steps_count, tau, h);

            for (int j = 0; j < t_steps_count - 1; j++)
            {
                SimpsonMethod integrator = new SimpsonMethod(b, 0, L, x_steps_count);
                double[] F = new double[x_steps_count];
                double integral = integrator.CalcConv2(grid, j);
                for (int i = 0; i < x_steps_count; i++)
                {
                    F[i] = -grid[i, j] * (1.0 + tau * (b(i * h) - integral));
                    progressBar.PerformStep();
                }
                double[] y = SLAE.Solve_SLAE(F);
                for (int i = 0; i < x_steps_count; i++)
                {
                    grid[i, j + 1] = y[i];
                    progressBar.PerformStep();
                }
            }

            progressBar.Value = progressBar.Maximum;
            return grid;
        }

        public static double[,] CalcA(double L,
                      double T,
                      double h,
                      double tau,
                      Func<double, double> phi,
                      Func<double, double> b,
                      ref ProgressBar progressBar)
        {
            progressBar.Value = progressBar.Minimum;

            int x_steps_count = Convert.ToInt32(L / h) + 1;
            int t_steps_count = Convert.ToInt32(T / tau) + 1;
            double[,] grid = new double[x_steps_count, t_steps_count];

            for (int i = 0; i < x_steps_count; i++)
            {
                grid[i, 0] = phi(i * h);
            }

            TridiagonalMatrix SLAE = PrepareTridiagonalMatrix(x_steps_count, tau, h);

            for (int j = 0; j < t_steps_count - 1; j++)
            {
                SimpsonMethod integrator = new SimpsonMethod(b, 0, L, x_steps_count);
                double[] F = new double[x_steps_count];
                double integral = integrator.CalcConv2(grid, j);
                for (int i = 0; i < x_steps_count; i++)
                {
                    F[i] = -grid[i, j] * (1.0 + tau * b(i * h));
                    progressBar.PerformStep();
                }
                double[] y = SLAE.Solve_SLAE(F);
                for (int i = 0; i < x_steps_count; i++)
                {
                    grid[i, j + 1] = y[i];
                    progressBar.PerformStep();
                }
            }

            SimpsonMethod integrator_A = new SimpsonMethod(x => 1.0, 0, L, x_steps_count);
            double integral_A = integrator_A.CalcConv2(grid, t_steps_count - 1);
            for (int i = 0; i < x_steps_count; i++)
            {
                grid[i, t_steps_count - 1] /= integral_A;
                progressBar.PerformStep();
            }

            progressBar.Value = progressBar.Maximum;
            return grid;
        }

        static TridiagonalMatrix PrepareTridiagonalMatrix(int N, double tau, double h)
        {
            double a = 1.0;
            double r = a * a * tau / (h * h);
            double A = r;
            double B = -(1.0 + 2.0 * r);
            double C = r;
            TridiagonalMatrix SLAE = new TridiagonalMatrix(N);
            SLAE[0, 0] = B;
            SLAE[0, 1] = C + A;
            SLAE[1, 0] = A;
            for (int i = 1; i < N - 2; i++)
            {
                SLAE[i, i] = B;
                SLAE[i, i + 1] = C;
                SLAE[i + 1, i] = A;
            }
            SLAE[N - 2, N - 2] = B;
            SLAE[N - 2, N - 1] = C;
            SLAE[N - 1, N - 2] = A + C;
            SLAE[N - 1, N - 1] = B;

            return SLAE;
        }
    }
}
