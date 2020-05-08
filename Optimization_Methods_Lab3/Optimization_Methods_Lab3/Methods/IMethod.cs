using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optimization_Methods_Lab3.Entities.Functions;

namespace Optimization_Methods_Lab3.Methods
{
    interface IMethod
    {
        List<string> getResults(PolynomialDerivativeFunction function, double x1, double x2, double e);
        List<string> getResults(RozenbokeFunction function, double x1, double x2, double e);
    }
}
