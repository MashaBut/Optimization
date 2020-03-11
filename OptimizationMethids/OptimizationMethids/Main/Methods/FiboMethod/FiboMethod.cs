using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethids.Main.Methods.FiboMethod
{
    class FiboMethod : IMethod
    {
        private bool isMaximization; // Искать макс знач функции если true
        private int n;               // Кол-во итераций
        public FiboMethod (bool isMaximization, int _n)
        {
            this.isMaximization = isMaximization;
            n = _n > 0 ? _n : 5;
            Console.WriteLine(n);
        }
        public IResult getResult(IFunction function, double a, double b)
        {
            FiboResult result = new FiboResult();
            double x;

            // Part 1
            double x1 = calcX1(a, b, n);
            double x2 = calcX2(a, b, n);
            double y1 = function.getY(x1);
            double y2 = function.getY(x2);

            result.addFirstStep(function.ToString(), x1, x2, y1, y2, n);

            // Part 2
            part2:
            n--;
            if ((y1 > y2 && !isMaximization) || (y1 < y2 && isMaximization))
            {
                a = x1;
                x1 = x2;
                x2 = b - (x1 - a);
                y1 = y2;
                y2 = function.getY(x2);
            } else
            {
                b = x2;
                x2 = x1;
                x1 = a + b - x2;
                y2 = y1;
                y1 = function.getY(x1);
            }

            result.addStep(a, b, x1, x2, y1, y2, n);

            // Part 3
            
            if (n == 1)
            {
                x = (x1 + x2) / 2;
            } else
            {
                goto part2;
            }
            result.addResultStep(x, function.getY(x));

            return result;
        }

        private double calcX1 (double a, double b, int n)
        {
            return a + (b - a) * getFib(n - 2) / getFib(n);
        }

        private double calcX2(double a, double b, int n)
        {
            return a + (b - a) * getFib(n - 1) / getFib(n);
        }

        private int getFib(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return a;
        }
    }
}
