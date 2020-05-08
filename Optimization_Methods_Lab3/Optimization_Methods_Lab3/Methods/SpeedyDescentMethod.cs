using System;
using System.Collections.Generic;
using Optimization_Methods_Lab3.Entities;
using Optimization_Methods_Lab3.Entities.Functions;
using Optimization_Methods_Lab3.Models;

namespace Optimization_Methods_Lab3.Methods
{
    class SpeedyDescentMethod : IMethod
    {
        public List<string> getResults(PolynomialDerivativeFunction function, double x1, double x2, double e)
        {
            return getResults(function, x1, x2, e, 0.1);
        }

        public List<string> getResults(RozenbokeFunction function, double x1, double x2, double e)
        {
            return getResults(function, x1, x2, e, 0.1);
        }

        public List<string> getResults(IDerivativeFunction function, double x1, double x2, double e, double lam)
        {
            List<string> results = new List<string>();

            int i = 0;
            // TO-DO remove code duplication
            Matrix grad = calculateGrad(function, x1, x2);
            x1 -= x1 - e * grad.get(0, 0);
            x2 -= x2 - e * grad.get(0, 1);
            results.Add(String.Format("k={0} x1={1} x2={2} f(x1,x2)={3}", i++, Math.Round(x1, 3), Math.Round(x2, 3), Math.Round(function.getY(x1, x2), 3)));
            Matrix prevGrad;
            do
            {
                prevGrad = grad;
                grad = calculateGrad(function, x1, x2);
                x1 -= lam * grad.get(0, 0);
                x2 -= lam * grad.get(0, 1);
                results.Add(String.Format("k={0} x1={1} x2={2} f(x1,x2)={3}", i++, Math.Round(x1, 3), Math.Round(x2, 3), Math.Round(function.getY(x1, x2), 3)));
            } while (Math.Abs((prevGrad - grad).get(0,0)) > e && Math.Abs((prevGrad - grad).get(0, 1)) > e);

            return results;
        }

        private Matrix calculateGrad(IDerivativeFunction function, double x1, double x2)
        {
            return new Matrix(new double[1, 2] {
                { function.getDerivativeX1().getY(x1, x2), function.getDerivativeX2().getY(x1, x2)}
            });
        }
    }
}
