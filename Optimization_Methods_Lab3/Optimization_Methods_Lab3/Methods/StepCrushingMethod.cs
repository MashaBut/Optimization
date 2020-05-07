using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3.Methods
{
    class StepCrushingMethod
    {
        public List<Rezult> rezults;
        public List<Rezult> rezultsRoz;

        IFunction _obj;
        Argements arg;

        public StepCrushingMethod(IFunction obj)
        {
            rezults = new List<Rezult>();
            rezultsRoz = new List<Rezult>();
            _obj = obj;
            arg = _obj.GetArgements();
            stepCrushingMethod(0.001, 0, 0);
            stepCrushingMethodRoz(0.001, 0, 0);
        }

        public void stepCrushingMethod(double eps, double x1, double x2) //епсилон для остановки x1 x2 - начальные точки
        {
            double alpha = 0.5; //начальное рандомное альфа
            double resFunc = 0, prevFunct = 0;
            double x1_prev, x2_prev; //х1 и х2 для предыдущей итерации
            double dx1, dx2;
            double betta = 0.3; 
            double lambda = 0.5;
            do
            {
                dx1 = df_dx1(x1, x2); //первая производная по х1
                dx2 = df_dx2(x1, x2); //первая производная по x2

                x1_prev = x1;
                x2_prev = x2;

                x1 -= alpha * dx1;//новое х1 
                x2 -= alpha * dx2;//новое х2

                prevFunct = function(x1_prev, x2_prev);
                resFunc = function(x1, x2);

                Rezult res = new Rezult();
                res.x = x1; res.y = x2; res.f = resFunc;
                rezults.Add(res);

                if (resFunc > prevFunct - 0.5 * alpha * Math.Sqrt(Math.Pow(dx1, 2) + Math.Pow(dx2, 2))) ;
                {
                    alpha = lambda * betta;
                }
            } while ((Math.Abs(resFunc - prevFunct) > eps));
        }

        public void stepCrushingMethodRoz(double eps, double x1, double x2) //епсилон для остановки x1 x2 - начальные точки
        {
            double alpha = 0.0006; //начальное рандомное альфа
            double resFunc = 0, prevFunct = 0;
            double x1_prev, x2_prev; //х1 и х2 для предыдущей итерации
            double dx1, dx2;
            double betta = 0.0003;
            double lambda = 0.0005;
            do
            {
                dx1 = df_dx1(x1, x2); //первая производная по х1
                dx2 = df_dx2(x1, x2); //первая производная по x2

                x1_prev = x1;
                x2_prev = x2;

                x1 -= alpha * dx1;//новое х1 
                x2 -= alpha * dx2;//новое х2

                prevFunct = functionRozenbrok(x1_prev, x2_prev);
                resFunc = functionRozenbrok(x1, x2);

                Rezult res = new Rezult();
                res.x = x1; res.y = x2; res.f = resFunc;
                rezultsRoz.Add(res);

                if (resFunc > prevFunct - 0.5 * alpha * Math.Sqrt(Math.Pow(dx1, 2) + Math.Pow(dx2, 2))) ;
                {
                    alpha = lambda * betta;
                }
            } while ((Math.Abs(resFunc - prevFunct) > eps));
        }

        double functionRozenbrok(double x1, double x2)
        {
            return 100 * Math.Pow((x2 - Math.Pow(x1, 2)), 2) + Math.Pow((1 - x1), 2);
        }

        double function(double x1, double x2)
        {
            return arg.a * x1 * x1 + arg.b * x1 * x2 + arg.c * x2 * x2 + arg.d * x1 + arg.e * x2;
        }

        public double df_dx1(double x1, double x2)
        {
            return 2 * arg.a * x1 + arg.b * x2 + arg.d;
        }

        public double df_dx2(double x1, double x2)
        {
            return arg.b * x1 + 2 * arg.c * x2 + arg.e;
        }

    }
}
