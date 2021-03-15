using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cauchy_Problem_Solver
{
    abstract class System_3_ODE
    {
        public abstract double f1(double x, double y, double z);
        public abstract double f2(double x, double y, double z);
        public abstract double f3(double x, double y, double z);
    }

    class Sample_S3ODE : System_3_ODE
    {
        public override double f1(double x, double y, double z) { return x - y - z; }
        public override double f2(double x, double y, double z) { return x + y; }
        public override double f3(double x, double y, double z) { return 3 * x + z; }
    }
}
