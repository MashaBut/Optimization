using Optimization_Methods_Lab3.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3
{
    class Argements
    {
        public int a { set; get; }
        public int b { set; get; }
        public int c { set; get; }
        public int d { set; get; }
        public int e { set; get; }

        public Argements(int _a, int _b, int _c, int _d, int _e)
        {
            a = _a;
            b = _b;
            c = _c;
            d = _d;
            e = _e;
        }
    }

    class Direction
    {
        public double x1 { set; get; }
        public double x2 { set; get; }

        public Direction(double _x1, double _x2)
        {
            x1 = _x1;
            x2 = _x2;
        }
    }
}
