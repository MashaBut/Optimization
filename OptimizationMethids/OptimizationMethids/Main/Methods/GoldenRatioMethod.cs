using OptimizationMethids.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethids
{
    class GoldenRatioObject
    {
        public double a;
        public double b;
        public double x1;
        public double x2;
        public double y1;
        public double y2;
    }

    class GoldenRatioMethod
    {
        private double a;
        private double b;
        private double x1;
        private double x2;
        private double epsilon = 0;
        private IFunction function;
        public double minX = 0;
        public double minF = 0;

        private List<GoldenRatioObject> results = new List<GoldenRatioObject>();
        public GoldenRatioMethod(IFunction function, double a, double b, double epsilon)
        {
            this.a = a;
            this.b = b;
            this.function = function;
            this.epsilon = epsilon;
            this.Method();
        }

        public List<GoldenRatioObject> getResults()
        {
            return results;
        }

        private void Method()
        {
            double delta2 = Math.Abs(b - a);
            double k = 0;
            while (delta2 > epsilon)
            {
                GoldenRatioObject elem = new GoldenRatioObject();
                elem.a = Math.Round(a, 4);
                elem.b = Math.Round(b, 4);
                elem.x1 = X1();
                elem.x2 = X2();
                elem.y1 = Y1();
                elem.y2 = Y2();
                results.Add(elem);
                if (Y1() >= Y2())
                {
                    a = x1;
                    x1 = x2;
                    x2 = a + (((Math.Sqrt(5) - 1) / 2) * (b - a));

                }
                else
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + (((3 - Math.Sqrt(5)) / 2) * (b - a));
                }
                delta2 = b - a;
                k = elem.a + elem.b;
            }
            minX = Math.Round((k / 2), 4);
            minF = function.getY(minX);
        }
        

        private double X1()
        {
            return Math.Round(a + (((3 - Math.Sqrt(5)) / 2) * (b - a)), 4);
        }

        private double X2()
        {
            return Math.Round(a + (((Math.Sqrt(5) - 1) / 2) * (b - a)), 4);
        }

        private double Y1()
        {
            return this.function.getY(X1());
        }

        private double Y2()
        {
            return this.function.getY(X2());
        }

    }
}
