using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethids.Main.Functions
{
    class Mashas26var :IFunction
    {
        public double getY(double x)
        {
            return Math.Round((Math.Pow(x, 2) / (x + 1)), 4);
        }

        public override string ToString()
        {
            return "x^2 / x+1";
        }
    }
}
