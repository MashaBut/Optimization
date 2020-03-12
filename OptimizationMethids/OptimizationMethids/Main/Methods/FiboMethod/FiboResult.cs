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
            result += $"Функция: {function} x1: {Math.Round(x1, 4)} x2:{Math.Round(x2, 4)} y1:{Math.Round(y1, 4)} y2:{Math.Round(y2, 4)} шаг: {n}";
            result += Environment.NewLine;
        }
        public void addStep (double a, double b, double x1, double x2, double y1, double y2, int n)
        {
            result += $"a: {Math.Round(a, 4)} b: {Math.Round(b, 4)} x1: {Math.Round(x1, 4)} x2:{Math.Round(x2, 4)} y1:{Math.Round(y1, 4)} y2:{Math.Round(y2, 4)} шаг: {n}";
            result += Environment.NewLine;
        }
        public void addResultStep(double x, double y)
        {
            result += $"Ответ: x={Math.Round(x, 4)} y={Math.Round(y, 4)}";
        }
        public override string ToString()
        {
            return result;
        }
    }
}
