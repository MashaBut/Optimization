using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3.Entities.Functions
{
    class RozenbokeFunction : Function
    {
        private const int NUMBER_OF_COEFFICIENTS = 2;
        public RozenbokeFunction(): base(NUMBER_OF_COEFFICIENTS) { }

        public override double getY(double x1, double x2)
        {
            return 100 * Math.Pow((x2 - Math.Pow(x1, 2)), 2) + Math.Pow(1 - x1, 2);
        }

        public override string ToString()
        {
            return "100*(x2 - (x1)^2)^2 + (1-x1)^2";
        }
    }
}
