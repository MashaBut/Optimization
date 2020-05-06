using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3.Methods
{
    class StepCrushingMethod
    {
        public List<Rezult> rezults;
        public List<Direction> points;
        IFunction _obj;
        Argements arg;
        Direction d;

        public StepCrushingMethod(IFunction obj)
        {
            rezults = new List<Rezult>();
            points = new List<Direction>();
            _obj = obj;
            d = _obj.getFirstDirectionX0();
            arg = _obj.GetArgements();
        }

        public void stepCrushingMethod()
        {
            double alfa = 0.5;
            double epsilon = 0.0001;
            double dx1 = df_dx1(d);
            double dx2 = df_dx2(d);

        }
        public double function(Direction d)
        {
            return arg.a * d.x1 * d.x1 + arg.b * d.x1 * d.x2 + arg.c * d.x2 * d.x2 + arg.d * d.x1 + arg.e * d.x2;
        }

        public double df_dx1(Direction d)
        {
            return 2 * arg.a * d.x1 + arg.b * d.x2 + arg.d;
        }

        public double df_dx2(Direction d)
        {
            return arg.b * d.x1 + 2 * arg.c * d.x2 + arg.e;
        }

    }
}
