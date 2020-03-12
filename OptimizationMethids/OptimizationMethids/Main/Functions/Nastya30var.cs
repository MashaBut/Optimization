using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethids.Main.Functions
{
    class Nastya30var:IFunction
    {
        public double getY(double x)
        {
            return Math.Round(x * Math.Exp(x), 4);
        }

        public override string ToString()
        {
            return "x*e(x)";
        }
    }
}
