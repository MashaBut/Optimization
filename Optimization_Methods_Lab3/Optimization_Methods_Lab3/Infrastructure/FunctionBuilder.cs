using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optimization_Methods_Lab3.Entities.Functions;
using Optimization_Methods_Lab3.Models;

namespace Optimization_Methods_Lab3.Infrastructure
{
    class FunctionBuilder
    {
        private Variant var { get; }

        public FunctionBuilder(Variant var)
        {
            this.var = var;
        }
        public PolynomialDerivativeFunction buildPolyFunction()
        {

            return new PolynomialDerivativeFunction(getArgs());
        }

        public RozenbokeFunction buildRozenFunction()
        {
            return new RozenbokeFunction();
        }

        private Arguments getArgs()
        {
            switch(this.var)
            {
                case Variant.MASHA: return new Arguments(3, 2, 1, 12, -6);
                case Variant.MISHA: return new Arguments(4, 2, 5, -2, -3);
                case Variant.NASTYA: return new Arguments(5, -2, 1, -2, 3);
                default: throw new Exception("No such implemented variant");
            }
        }
    }
}
