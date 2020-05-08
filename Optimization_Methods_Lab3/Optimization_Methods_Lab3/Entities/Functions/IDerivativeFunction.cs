using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3.Entities.Functions
{
    interface IDerivativeFunction : IFunction
    {
        Function getDerivativeX1();
        Function getDerivativeX2();
    }
}
