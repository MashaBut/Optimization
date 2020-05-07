using Optimization_Methods_Lab3.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3
{

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
