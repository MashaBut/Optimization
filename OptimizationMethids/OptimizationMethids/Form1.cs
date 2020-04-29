using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using OptimizationMethids.Main;
using OptimizationMethids.Main.Methods.FiboMethod;
using OptimizationMethids.Main.Functions;

namespace OptimizationMethids
{
    public partial class Form1 : Form
    {

        private IFunction function = new Mishas7var();
        public Form1()
        {
            InitializeComponent();
        }

        public void buildgraph(IFunction function, double a, double b, Color C)
        {
            Graphics g = chart.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            float W = chart.Width, H = chart.Height; //w-ширина
            Pen RedPen = new Pen(C, 2);
            List<PointF> Points = new List<PointF>();
            double y, xx, yy, x1, y1, x2, y2;
            double count = 0;
            for (double x = a; x <= b; x += 0.1)
            {
                y = function.getY(x);
                xx = W / 2 + x * 41;
                yy = H / 2 - y * 41;
                PointF point = new PointF((float)xx, (float)yy);
                Points.Add(point);
                count++;
            }
            x1 = Points[0].X;
            y1 = Points[0].Y;
            for (int i = 1; i <= count - 1; i++)
            {
                x2 = Points[i].X;
                y2 = Points[i].Y;
                try
                {
                    g.DrawLine(RedPen, (float)x1, (float)y1, (float)x2, (float)y2);
                }
                catch { }
                x1 = x2;
                y1 = y2;
            }
        }

        private void btnForHalfDivisionMethod_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(leftBorders.Text);
            double b = Convert.ToDouble(rightBorders.Text);
            double d = Convert.ToDouble(delta.Text);
            double eps = Convert.ToDouble(epsilon.Text);

            HalfDivisionMethod method = new HalfDivisionMethod(function, a, b, d, eps);
            List<HalfDivisionObject> rez = method.getResults();
            textBoxForHalfDivisionMethod.Clear();
            foreach (HalfDivisionObject r in rez)
            {
                textBoxForHalfDivisionMethod.Text += $"a = {r.a}  b = {r.b}  lambda = {r.lambda}  psi = {r.pci}  f(lambda) = {r.funcLambda}  f(psi) = {r.funcPci}" + '\r' + '\n';
            }
            textBoxForHalfDivisionMethod.Text += $"Ответ Xmin = {method.minX}  f(Xmin) = {method.minF}";
            buildgraph(function, a, b, Color.Red);
        }

        private void btnForGoldenRadioMethod_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(leftBorders.Text);
            double b = Convert.ToDouble(rightBorders.Text);
            double eps = Convert.ToDouble(epsilon.Text);

            GoldenRatioMethod method = new GoldenRatioMethod(function, a, b, eps);
            List<GoldenRatioObject> rez = method.getResults();
            textBoxForGoldenRadioMethod.Clear();
            foreach (GoldenRatioObject r in rez)
            {
                textBoxForGoldenRadioMethod.Text += $"a = {r.a}  b = {r.b}  x1 = {r.x1}  x2 = {r.x2}  y1 = {r.y1}  y2 = {r.y2}" + '\r' + '\n';
            }
            textBoxForGoldenRadioMethod.Text += $"Ответ Xmin = {method.minX}  f(Xmin) = {method.minF}";
            buildgraph(function, a, b, Color.Green);

        }

        private void btnForFibonachiMethod_Click(object sender, EventArgs e)
        {
            double a, b;
            int n;
            double.TryParse(leftBorders.Text, out a);
            double.TryParse(rightBorders.Text, out b);
            int.TryParse(nTextBox.Text, out n);

            IMethod fibo = new FiboMethod(false, n);

            showResults(fibo.getResult(function, a, b));
            buildgraph(function, a, b, Color.Blue);
        }

        private void showResults(IResult results)
        {
            textBoxForFibonachiMethod.Text = results.ToString();
        }


    }
}
