using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optimization_Methods_Lab3.Entities.Functions;
using Optimization_Methods_Lab3.Entities;

namespace Optimization_Methods_Lab3.Methods
{
    class NewtonMethod : IMethod
    {

        public List<string> getResults(PolynomialDerivativeFunction function, double x1, double x2, double e)
        {
            List<string> results = new List<string>();
            Matrix grad = null;
            Matrix gesse = getInverseGessePoly(function);
            int i = 1;
            do
            {
                grad = calculateGrad(function, x1, x2);
                Matrix res = gesse * grad;
                x1 -= res.get(0, 0);
                x2 -= res.get(0, 1);
                results.Add(String.Format("k={0} x1={1} x2={2} f(x1,x2)={3}", i++, Math.Round(x1, 3), Math.Round(x2, 3), Math.Round(function.getY(x1, x2), 3)));
            } while (grad == null || (Math.Abs(grad.get(0, 0)) > e && Math.Abs(grad.get(0, 1)) > e));

            return results;
        }

        public List<string> getResults(RozenbokeFunction function, double x1, double x2, double e)
        {
            List<string> results = new List<string>();
            Matrix grad = null;
            int i = 1;
            do
            {
                grad = calculateGrad(function, x1, x2);
                Matrix gesse = getInverseGesseRoz(x1, x2);
                Matrix res = gesse * grad;
                x1 -= res.get(0, 0);
                x2 -= res.get(0, 1);
                results.Add(String.Format("k={0} x1={1} x2={2} f(x1,x2)={3}", i++, Math.Round(x1, 3), Math.Round(x2, 3), Math.Round(function.getY(x1, x2), 3)));
            } while (grad == null || (Math.Abs(grad.get(0, 0)) > e || Math.Abs(grad.get(0, 1)) > e));

            return results;
        }


        private Matrix getInverseGessePoly(PolynomialDerivativeFunction function)
        {
            double [,] arr = new double [2,2] {
                { function.coefficients.a * 2, function.coefficients.b },
                { function.coefficients.b, function.coefficients.c * 2 }
            };
            return new Matrix(arr).getInverseMatrix();
        }
        private Matrix getInverseGesseRoz(double x1, double x2)
        {
            double[,] arr = new double[2, 2] {
                { 1200*Math.Pow(x1,2)-400*x2+2, -400*x1 },
                { -400*x1, 200 }
            };
            return new Matrix(arr).getInverseMatrix();
        }

        private Matrix calculateGrad(IDerivativeFunction function, double x1, double x2)
        {
            return new Matrix(new double[1, 2] {
                { function.getDerivativeX1().getY(x1, x2), function.getDerivativeX2().getY(x1, x2)}
            });
        }

        
    }
}
