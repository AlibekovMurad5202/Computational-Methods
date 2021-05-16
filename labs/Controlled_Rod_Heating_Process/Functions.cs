using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controlled_Rod_Heating_Process
{
    class Functions
    {
        public static double L = 0;
        public static double phi_1 = 0;
        public static double phi_2 = 0;

        public static double b_0 = 0;
        public static double b_1 = 0;
        public static double b_2 = 0;

        public static double phi(double x)
        {
            return 1.0 / L + phi_1 * Math.Cos(Math.PI * x / L) + phi_2 * Math.Cos(2 * Math.PI * x / L);
        }

        public static double b(double x)
        {
            return b_0 + b_1 * Math.Cos(Math.PI * x / L) + b_2 * Math.Cos(2 * Math.PI * x / L);
        }
    }
}
