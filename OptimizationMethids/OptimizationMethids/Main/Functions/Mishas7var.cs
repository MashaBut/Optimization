using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethids.Main.Functions
{
    class Mishas7var : IFunction
    {
        public double getY(double x)
        {
            return Math.Round((-Math.Pow(x, 4) + 2 * Math.Pow(x, 2) - 3), 4);
        }

        public override string ToString()
        {
            return "x^4 - 2x^2 + 3";
        }
    }
}
