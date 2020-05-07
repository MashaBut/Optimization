using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optimization_Methods_Lab3.Entities.Functions;
using Optimization_Methods_Lab3.Entities;

namespace Optimization_Methods_Lab3.Methods
{
    class NewtonMethod
    {
        public double[] act(PolynomialDerivativeFunction function, double x1, double x2, double e)
        {
            Matrix gesse = getInverseGesse(function);

            for (int i = 0; i < 8; i++)
            {
                Matrix grad = calculateGrad(function, x1, x2);

                Matrix res = gesse * grad;

                x1 -= res.get(0, 0);
                x2 -= res.get(0, 1);
            }
            Console.WriteLine(x1 + " " + x2);

            return null;
        }

        private Matrix getInverseGesse(PolynomialDerivativeFunction function)
        {
            double [,] arr = new double [2,2] {
                { function.coefficients.a * 2, function.coefficients.b },
                { function.coefficients.b, function.coefficients.c * 2 }
            };
            //double det = arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0];
            //arr[0, 0] /= det;
            //arr[0, 1] /= det;
            //arr[1, 0] /= det;
            //arr[1, 1] /= det;
            return new Matrix(arr).getInverseMatrix();
        }

        private Matrix calculateGrad(PolynomialDerivativeFunction function, double x1, double x2)
        {
            return new Matrix(new double[1, 2] {
                { function.getDerivativeX1().getY(x1, x2), function.getDerivativeX2().getY(x1, x2)}
            });
        }
    }
}
