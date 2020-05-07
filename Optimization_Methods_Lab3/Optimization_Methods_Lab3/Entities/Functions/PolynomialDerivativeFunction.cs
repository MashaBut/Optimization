using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Optimization_Methods_Lab3.Models;

namespace Optimization_Methods_Lab3.Entities.Functions
{
    class PolynomialDerivativeFunction : PolynomialFunction
    {
        public PolynomialDerivativeFunction(Arguments koef) : base(koef) { }

        public Function getDerivativeX1()
        {
            return new F1(coefficients.a, coefficients.b, coefficients.d);
        }

        public Function getDerivativeX2()
        {
            return new F2(coefficients.b, coefficients.c, coefficients.e);
        }

        public Function getDerivativeX1X2()
        {
            return new F3(coefficients.b);
        }

        private class F1 : Function
        {
            private double a;
            private double b;
            private double d;
            public F1(double a, double b, double d) : base(2)
            {
                this.a = a;
                this.b = b;
                this.d = d;
            }
            public override double getY(double x1, double x2) => 2 * a * x1 + b * x2 + d;

            public override string ToString()
            {
                throw new NotImplementedException();
            }
        }

        private class F2 : Function
        {
            private double b;
            private double c;
            private double e;
            public F2(double b, double c, double e) : base(2)
            {
                this.b = b;
                this.c = c;
                this.e = e;
            }
            public override double getY(double x1, double x2) => b * x1 + 2 * x2 * c + e;

            public override string ToString()
            {
                throw new NotImplementedException();
            }
        }

        private class F3 : Function
        {
            private double b;
            public F3(double b) : base(2) {
                this.b = b;
            }
            public override double getY(double x1, double x2) => b;

            public override string ToString()
            {
                throw new NotImplementedException();
            }
        }

    }
    
}
