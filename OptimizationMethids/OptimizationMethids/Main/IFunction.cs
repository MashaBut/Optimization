using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethids.Main
{
    public interface IFunction
    {
        double getY(double x);

        string ToString();
    }
}
