using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3.Entities.Functions
{
    class RozenbokeFunction : Function, IDerivativeFunction
    {
        private const int NUMBER_OF_COEFFICIENTS = 2;
        public RozenbokeFunction(): base(NUMBER_OF_COEFFICIENTS) { }

        public override double getY(double x1, double x2) => -(100 * Math.Pow((x2 - Math.Pow(x1, 2)), 2) + Math.Pow(1 - x1, 2));
        public override string ToString() => "100*(x2 - (x1)^2)^2 + (1-x1)^2";
        public Function getDerivativeX1() => new F1();
        public Function getDerivativeX2() => new F2();
        private class F1 : Function
        {
            public F1() : base(2) { }
            public override double getY(double x1, double x2) => -400 * x1 * (x2 - Math.Pow(x1, 2)) + 2 * x1 - 2;
            public override string ToString() => throw new NotImplementedException();
        }
        private class F2 : Function
        {
            public F2() : base(2) { }
            public override double getY(double x1, double x2) => 200*x2-200* Math.Pow(x1,2);
            public override string ToString() => throw new NotImplementedException();
        }
    }
}
