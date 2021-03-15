using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cauchy_Problem_Solver
{
    static class RK4Method
    {
        public static List<double[]> Solve(System_3_ODE system_3_ODE, 
            double interval_a, double interval_b, int steps, double[] initial_conditions)
        {
            // System_3_ODE system_3_ODE;  // система ОДУ из 3-х уравнений
            // double interval_a;  // интервал интегрирования
            // double interval_b;  // интервал интегрирования
            // double h;  // величина шага 
            // int steps;  // число шагов интегрирования

            double x_0 = initial_conditions[0];
            double y_0 = initial_conditions[1];
            double z_0 = initial_conditions[2];
            double t_0 = initial_conditions[3];

            double h = (interval_b - interval_a) / steps;

            List<double[]> result = new List<double[]> { };

            double x, y, z;
            double x_prev = x_0, y_prev = y_0, z_prev = z_0;

            double[,] k = new double[4, 3];
            
            for (double t = t_0 + h; t < interval_b + h; t += h)
            {
                k[0, 0] = h * system_3_ODE.f1(x_prev, y_prev, z_prev);
                k[0, 1] = h * system_3_ODE.f2(x_prev, y_prev, z_prev);
                k[0, 2] = h * system_3_ODE.f3(x_prev, y_prev, z_prev);

                k[1, 0] = h * system_3_ODE.f1(x_prev + k[0, 0] / 2, 
                                              y_prev + k[0, 1] / 2, 
                                              z_prev + k[0, 2] / 2);
                k[1, 1] = h * system_3_ODE.f2(x_prev + k[0, 0] / 2,
                                              y_prev + k[0, 1] / 2,
                                              z_prev + k[0, 2] / 2);
                k[1, 2] = h * system_3_ODE.f3(x_prev + k[0, 0] / 2,
                                              y_prev + k[0, 1] / 2,
                                              z_prev + k[0, 2] / 2);
                
                k[2, 0] = h * system_3_ODE.f1(x_prev + k[1, 0] / 2,
                                              y_prev + k[1, 1] / 2,
                                              z_prev + k[1, 2] / 2);
                k[2, 1] = h * system_3_ODE.f2(x_prev + k[1, 0] / 2,
                                              y_prev + k[1, 1] / 2,
                                              z_prev + k[1, 2] / 2);
                k[2, 2] = h * system_3_ODE.f3(x_prev + k[1, 0] / 2,
                                              y_prev + k[1, 1] / 2,
                                              z_prev + k[1, 2] / 2);

                k[3, 0] = h * system_3_ODE.f1(x_prev + k[2, 0], y_prev + k[2, 1], z_prev + k[2, 2]);
                k[3, 1] = h * system_3_ODE.f2(x_prev + k[2, 0], y_prev + k[2, 1], z_prev + k[2, 2]);
                k[3, 2] = h * system_3_ODE.f3(x_prev + k[2, 0], y_prev + k[2, 1], z_prev + k[2, 2]);

                x = x_prev + (k[0, 0] + 2 * k[1, 0] + 2 * k[2, 0] + k[3, 0]) / 6;
                y = y_prev + (k[0, 1] + 2 * k[1, 1] + 2 * k[2, 1] + k[3, 1]) / 6;
                z = z_prev + (k[0, 2] + 2 * k[1, 2] + 2 * k[2, 2] + k[3, 2]) / 6;

                if ((t > interval_a) && (t < interval_a + steps * h))
                    result.Add(new double[4] { x, y, z, t });
                x_prev = x;
                y_prev = y;
                z_prev = z;
            }

            // из-за ошибок типа double (0.1 + 0.2 == 0.30000000004)
            if (result.Count < steps)
            {
                k[0, 0] = h * system_3_ODE.f1(x_prev, y_prev, z_prev);
                k[0, 1] = h * system_3_ODE.f2(x_prev, y_prev, z_prev);
                k[0, 2] = h * system_3_ODE.f3(x_prev, y_prev, z_prev);

                k[1, 0] = h * system_3_ODE.f1(x_prev + k[0, 0] / 2,
                                              y_prev + k[0, 1] / 2,
                                              z_prev + k[0, 2] / 2);
                k[1, 1] = h * system_3_ODE.f2(x_prev + k[0, 0] / 2,
                                              y_prev + k[0, 1] / 2,
                                              z_prev + k[0, 2] / 2);
                k[1, 2] = h * system_3_ODE.f3(x_prev + k[0, 0] / 2,
                                              y_prev + k[0, 1] / 2,
                                              z_prev + k[0, 2] / 2);

                k[2, 0] = h * system_3_ODE.f1(x_prev + k[1, 0] / 2,
                                              y_prev + k[1, 1] / 2,
                                              z_prev + k[1, 2] / 2);
                k[2, 1] = h * system_3_ODE.f2(x_prev + k[1, 0] / 2,
                                              y_prev + k[1, 1] / 2,
                                              z_prev + k[1, 2] / 2);
                k[2, 2] = h * system_3_ODE.f3(x_prev + k[1, 0] / 2,
                                              y_prev + k[1, 1] / 2,
                                              z_prev + k[1, 2] / 2);

                k[3, 0] = h * system_3_ODE.f1(x_prev + k[2, 0], y_prev + k[2, 1], z_prev + k[2, 2]);
                k[3, 1] = h * system_3_ODE.f2(x_prev + k[2, 0], y_prev + k[2, 1], z_prev + k[2, 2]);
                k[3, 2] = h * system_3_ODE.f3(x_prev + k[2, 0], y_prev + k[2, 1], z_prev + k[2, 2]);

                x = x_prev + (k[0, 0] + 2 * k[1, 0] + 2 * k[2, 0] + k[3, 0]) / 6;
                y = y_prev + (k[0, 1] + 2 * k[1, 1] + 2 * k[2, 1] + k[3, 1]) / 6;
                z = z_prev + (k[0, 2] + 2 * k[1, 2] + 2 * k[2, 2] + k[3, 2]) / 6;

                result.Add(new double[4] { x, y, z, interval_b });
                x_prev = x;
                y_prev = y;
                z_prev = z;
            }

            return result;
        }
    }
}
