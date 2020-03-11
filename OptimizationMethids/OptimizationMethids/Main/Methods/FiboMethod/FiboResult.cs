using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethids.Main.Methods.FiboMethod
{
    class FiboResult : IResult
    {
        private string result; // Да простят меня за такое

        public void addFirstStep (string function, double x1, double x2, double y1, double y2, int n)
        {
            result += $" функция: {function} x1: {Math.Round(x1, 2)} x2:{Math.Round(x2, 2)} y1:{Math.Round(y1, 2)} y2:{Math.Round(y2, 2)} шаг: {n}";
            result += Environment.NewLine;
        }
        public void addStep (double a, double b, double x1, double x2, double y1, double y2, int n)
        {
            result += $"a: {Math.Round(a, 2)} b: {Math.Round(b, 2)} x1: {Math.Round(x1, 2)} x2:{Math.Round(x2, 2)} y1:{Math.Round(y1, 2)} y2:{Math.Round(y2, 2)} шаг: {n}";
            result += Environment.NewLine;
        }
        public void addResultStep(double x, double y)
        {
            result += $"result: x={Math.Round(x, 2)} y={Math.Round(y, 2)}";
        }
        public override string ToString()
        {
            return result;
        }
    }
}
