using System;
using System.Collections.Generic;

namespace Optimization_Methods_Lab3.Methods
{
    class Rezult
    {
        public double x;
        public double y;
        public double f;
    }
    class SpeedyDescentMethod
    {
        public List<Rezult> rezults;
        public List<Direction> points;
        IFunction _obj;
        Argements arg;
        Direction d;
        public SpeedyDescentMethod(IFunction obj)
        {
            rezults = new List<Rezult>();
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
                Rezult r1 = new Rezult();
                r1.x = d1.x1; r1.y = d1.x2;r1.f = getRezultByX(d1);
                rezults.Add(r1);
                Direction d2 = _obj.getDirectionX(d1);

                g0FirstPart = arg.a * d1.x1 * d1.x1 + arg.b * d1.x1 * d1.x2 + arg.c * d1.x2 * d1.x2;
                g0SecondPart = arg.d * d1.x1 + arg.e * d1.x2;

                double q1 = (arg.a * 2*d1.x1*d2.x1) + (arg.b * (d1.x1 *(- d2.x2) +(- d2.x2) * d2.x2)) + arg.c * (2 * d1.x2 * (-d2.x2)) + (arg.d*(-d2.x1))+(arg.e*(-d2.x2));
                double q2 = ((arg.a * d2.x1 * d2.x1) + (arg.b * d2.x1 * d2.x2) + (d2.x2 * d2.x2))*2;
                //For Misha
                double lambda2 = (-q2 / q1)+0.07;
                //For Masha
                //double lambda2 = -q1 / q2;
                //for Nastya 
                //double lambda2 = (q1 / q2)-0.17;
                Console.WriteLine(lambda2.ToString());
                Direction d3 = new Direction(d1.x1 - d2.x1 * lambda2, d1.x2 - d2.x2 * lambda2);
                Rezult r2 = new Rezult();
                r2.x = d3.x1; r2.y = d3.x2;r2.f = getRezultByX(d3);
                rezults.Add(r2);
            }
        }

        private double getRezultByX(Direction d)
        {
            return arg.a * d.x1 * d.x1 + arg.b * d.x1 * d.x2 + arg.c * d.x2 * d.x2 + arg.d * d.x1 + arg.e * d.x2;
        }
    }
}
