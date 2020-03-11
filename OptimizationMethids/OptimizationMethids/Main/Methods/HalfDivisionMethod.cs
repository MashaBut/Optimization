using System;
using System.Collections.Generic;

namespace OptimizationMethids
{
    class HalfDivisionObject
    {
        public double a;
        public double b;
        public double lambda;
        public double pci;
        public double funcLambda;
        public double funcPci;
    }
    class HalfDivisionMethod
    {
        private double a;
        private double b;
        private double delta;
        private double epsilon =0;
        public double minX = 0;
        public double minF = 0;


        private List<HalfDivisionObject> results = new List<HalfDivisionObject>();
        public HalfDivisionMethod(double a, double b,double delta, double epsilon)
        {
            this.a = a;
            this.b = b;
            this.delta = delta;
            this.epsilon = epsilon;
            this.Method();
        }

        private double Function(double x)
        {
            //Mary
            return Math.Round((Math.Pow(x, 2) / (x + 1)), 4);
            //Nastay
            //return Math.Round(x * Math.Exp(x), 4);
            //Misha
            //return Math.Round(-(Math.Pow(x, 4) + 2 * Math.Pow(x, 2) - 3), 4);
            //Shevelova
            //return Math.Round(Math.Pow(x, 2) + 2 * x, 4);
        }

        public List<HalfDivisionObject> getResults()
        {
            return results;
        }

        private void Method()
        {
            double delta2 = b - a;
            while(delta2 > epsilon)
            {
                HalfDivisionObject elem = new HalfDivisionObject();
                elem.a = a;
                elem.b = b;
                elem.lambda = Math.Round(this.Lambda(),4);
                elem.pci = Math.Round(this.Pci(),4);
                elem.funcLambda = this.FuncLambda(elem.lambda);
                elem.funcPci = this.FuncPci(elem.pci);
                results.Add(elem);
                if (elem.funcLambda <= elem.funcPci)
                {
                    b = elem.pci;
                    minF = elem.funcLambda;
                    minX = elem.lambda;
                }
                else if (elem.funcLambda > elem.funcPci)
                {
                    a = elem.lambda;
                    minF = elem.funcPci;
                    minX = elem.pci;
                }
                delta2 = b - a;
            }
        }

        private double Lambda()
        {
            return (a + b - delta) / 2;
        }

        private double Pci()
        {
            return (a + b + delta) / 2;
        }

        private double FuncPci(double x)
        {
            return this.Function(x);
        }

        private double FuncLambda(double x)
        {
            return this.Function(x);
        }
    }
}
