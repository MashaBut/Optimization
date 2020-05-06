using Optimization_Methods_Lab3.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3
{
    class Masha:IFunction
    {
        Argements obj = new Argements(3, 2, 1, 12, -6);
        Direction d = new Direction(12, -6);
        public Argements GetArgements()
        {
            return obj;
        }

        public string getFunciton()
        {
            return "3x1^2+2x1x2+x2^2+12x1-6x2";
        }

        public string getRozenbrokeFunction()
        {
            return "100(x2-x1^2)^2 + (1-x1)^2";
        }

        public Direction getFirstDirectionX0()
        {
            return d;
        }

        public Direction getDirectionX(Direction d)
        {
            Direction dd = new Direction(6 * d.x1 + 2 * d.x2 + 12, 2 * d.x1 + 2 * d.x2 - 6);
            return dd;
        }
    }
}
