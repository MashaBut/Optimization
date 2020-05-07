using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Optimization_Methods_Lab3.Models;

namespace Optimization_Methods_Lab3.Entities.Functions
{
    class PolynomialFunction : Function
    {
        public Arguments coefficients { get; protected set; }
        private const int NUMBER_OF_COEFFICIENTS = 2;

        public PolynomialFunction(Arguments koef) : base(NUMBER_OF_COEFFICIENTS)
        {
            this.coefficients = koef;
        }

        public override double getY(double x1, double x2)
        {
            return coefficients.a * Math.Pow(x1, 2) + coefficients.b * x1 * x2 + coefficients.c * Math.Pow(x2, 2) + coefficients.d * x1 + coefficients.e * x2;
        }

        public override string ToString()
        {
            return String.Format("{0}*(x1)^2 + {1}*x1*x2 + {2}*(x2)^2 + {3}*x1 + {4}*x2",
                coefficients.a,
                coefficients.b,
                coefficients.c,
                coefficients.d,
                coefficients.e
            );
        }
    }
}
