using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3.Methods
{
    class SpeedyDescentMethod
    {
        public List<Direction> points;
        IFunction _obj;
        int[] deraction = new int[2];
        Argements arg;
        Direction d;
        public SpeedyDescentMethod(IFunction obj)
        {
            points = new List<Direction>();
            _obj = obj;
            d = _obj.getFirstDirectionX0();
            arg = _obj.GetArgements();
            firstStep();
            points.Add(d);
        }

        private void firstStep()
        {
            double g0FirstPart = arg.a * d.x1 * d.x1 + arg.b * d.x1 * d.x2 + arg.c * d.x2 * d.x2;
            double g0SecondPart = arg.d * d.x1 + arg.e * d.x2;
            double lambda = -g0SecondPart/(g0FirstPart*2);
            Direction d1 = new Direction(d.x1 * lambda, d.x2 * lambda);
            points.Add(d1);
            if (getRezultByX(d1) < getRezultByX(d))
            { 
                Direction d2 = _obj.getDirectionX(d1);

                Console.WriteLine(d1.x1.ToString() + " " + d1.x2.ToString());
                Console.WriteLine(d2.x1.ToString() + " " + d2.x2.ToString());


                g0FirstPart = arg.a * d1.x1 * d1.x1 + arg.b * d1.x1 * d1.x2 + arg.c * d1.x2 * d1.x2;
                g0SecondPart = arg.d * d1.x1 + arg.e * d1.x2;


                double q1 = (arg.a * 2*d1.x1*d2.x1) + (arg.b * (d1.x1 *(- d2.x2) +(- d2.x2) * d2.x2)) + arg.c * (2 * d1.x2 * (-d2.x2)) + (arg.d*(-d2.x1))+(arg.e*(-d2.x2));
                double q2 = ((arg.a * d2.x1 * d2.x1) + (arg.b * d2.x1 * d2.x2) + (d2.x2 * d2.x2))*2;
                double lambda2 = -q1 / q2;
                Direction d3 = new Direction(d1.x1 - d2.x1 * lambda2, d1.x2 - d2.x2 * lambda2);
                Console.WriteLine(d3.x1.ToString() + " " + d3.x2.ToString());
                points.Add(d3);
            }
        }

        private double getRezultByX(Direction d)
        {
            return arg.a * d.x1 * d.x1 + arg.b * d.x1 * d.x2 + arg.c * d.x2 * d.x2 + arg.d * d.x1 + arg.e * d.x2;
        }
    }
}
