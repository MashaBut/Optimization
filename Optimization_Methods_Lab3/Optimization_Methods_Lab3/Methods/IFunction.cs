using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3.Methods
{
    interface IFunction 
    {
        string getFunciton();

        Argements GetArgements();
        
        Direction getFirstDirectionX0();

        Direction getDirectionX(Direction d);

    }
}
