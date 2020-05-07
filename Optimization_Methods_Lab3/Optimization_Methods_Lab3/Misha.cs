namespace Optimization_Methods_Lab3.Methods
{
    class Misha : IFunction
    {//var 7
        Argements obj = new Argements(4,2,5,-2,-3);
        Direction d = new Direction(-2, -3);
        public Argements GetArgements()
        {
            return obj;
        }

        public string getFunciton()
        {
            return "4x1^2+2x1x2+5x2^2-2x1-3x2";
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
            Direction dd = new Direction(8 * d.x1 + 2 * d.x2 -2, 2 * d.x1 + 10 * d.x2 - 3);
            return dd;
        }
    }
}
