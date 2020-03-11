using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethids.Main
{
    interface IMethod
    {
        IResult getResult(IFunction function, double from, double to);
    }
}
