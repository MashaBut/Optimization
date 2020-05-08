using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3.Entities.Functions
{
    interface IFunction
    {
        double getY(double x1, double x2);
    }
}
