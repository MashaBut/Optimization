using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Optimization_Methods_Lab3.Entities.Functions;
using Optimization_Methods_Lab3.Models;

namespace Optimization_Methods_Lab3.Methods
{
    class StepCrushingMethod : IMethod
    {
        public List<string> getResults(PolynomialDerivativeFunction function, double eps, double x1, double x2)
        {
            return getResults(function, eps, x1, x2, 0.5, 0.3, 0.5);
        }

        public List<string> getResults(RozenbokeFunction function, double eps, double x1, double x2)
        {
            return getResults(function, eps, x1, x2, 0.0006, 0.0003, 0.0005);
        }

        private List<string> getResults(IDerivativeFunction function, double eps, double x1, double x2, double alpha, double betta, double lambda)
        {
            List<string> results = new List<string>();
            double x1_prev, x2_prev;
            double dx1, dx2;
            double prevFunc, resFunc;
            int k = 1;

            do
            {
                dx1 = function.getDerivativeX1().getY(x1, x2); //первая производная по х1
                dx2 = function.getDerivativeX2().getY(x1, x2); //первая производная по x2

                x1_prev = x1;
                x2_prev = x2;

                x1 -= alpha * dx1;//новое х1 
                x2 -= alpha * dx2;//новое х2

                prevFunc = function.getY(x1_prev, x2_prev);
                resFunc = function.getY(x1, x2);

                results.Add(String.Format("k={0} x1={1} x2={2} f(x1,x2)={3}", k++, Math.Round(x1, 3), Math.Round(x2, 3), Math.Round(resFunc,3)));

                if (resFunc > prevFunc - 0.5 * lambda * Math.Sqrt(Math.Pow(dx1, 2) + Math.Pow(dx2, 2)))
                {
                    alpha = lambda * betta;
                }
            } while ((Math.Abs(resFunc - prevFunc) > eps));

            return results;
        }
    }
}
