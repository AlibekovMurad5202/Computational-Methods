using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controlled_Rod_Heating_Process
{
    public class SimpsonMethod
    {
        Func<double, double> f;
        double a;
        double b;
        int n;

        public SimpsonMethod(Func<double, double> f, double a, double b, int n)
        {
            this.a = a;
            this.b = b;
            this.n = n;
            this.f = f;
        }

        public double Calc()
        {
            var h = (b - a) / n;
            double res = f(a) + f(b);
            
            for (int i = 1; i < n - 1; i++)
            {
                double x = i * h;
                res += ((i % 2 == 0) ? 2 : 4) * f(x);
            }

            return res * (h / 3);
        }

        public double CalcConv(double[] conv)
        {
            double h = (b - a) / n;
            double res = f(a) * conv[0] + f(b) * conv[n - 1];

            for (int i = 1; i < n; i++)
            {
                double x = i * h;
                res += ((i % 2 == 0) ? 2 : 4) * f(x) * conv[i];
            }

            return res * (h / 3);
        }

        public double CalcConv2(double[,] conv, int t)
        {
            double h = (b - a) / n;
            double res = f(a) * conv[0, t] + f(b) * conv[n - 1, t];

            for (int i = 1; i < n; i++)
            {
                double x = i * h;
                res += ((i % 2 == 0) ? 2 : 4) * f(x) * conv[i, t];
            }

            return res * (h / 3);
        }
    }
}
