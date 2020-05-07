using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3.Entities.Functions
{
    abstract class Function 
    {
        protected int argsLength;
        
        public Function(int argsLength)
        {
            this.argsLength = argsLength;
        }
        public override abstract string ToString();
        public abstract double getY(double x1, double x2); // Please use "params double[] args" if you need more generic approach

    }
}
