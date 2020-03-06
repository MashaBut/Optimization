using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OptimizationMethids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void buildgraph(object sender, EventArgs e, double a, double b,Color C)
        {
            Graphics g = chart.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            float W = chart.Width, H = chart.Height; //w-ширина
            Pen RedPen = new Pen(C, 2);
            List<PointF> Points = new List<PointF>();
            double y, xx, yy, x1, y1, x2, y2;
            double count=0;
            for (double x = a; x <= b; x+=0.1)
            {
                y = func(x);
                xx = W / 2 + x * 53;
                yy = H / 2 - y * 50;
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

        private double func(double x)
        {
            //Mary
            // return Math.Round((Math.Pow(x, 2) / (x + 1)), 3);
            //Nastay
            //return Math.Round(x * Math.Exp(x),3);
            //Misha
            return Math.Round(-(Math.Pow(x, 4) + 2 * Math.Pow(x, 2) - 3), 3);
        }

        private void btnForHalfDivisionMethod_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(leftBorders.Text);
            double b =  Convert.ToDouble(rightBorders.Text);
            double d =  Convert.ToDouble(delta.Text);
            double eps = Convert.ToDouble(epsilon.Text);
            HalfDivisionMethod method = new HalfDivisionMethod(a, b, d, eps);
            List<HalfDivisionObject> rez = method.getResults();
            textBoxForHalfDivisionMethod.Clear();
            foreach (HalfDivisionObject r in rez)
            {
                textBoxForHalfDivisionMethod.Text += $"a={r.a}  b={r.b}  lambda={r.lambda}  pci={r.pci}  f(lambda)={r.funcLambda}  f(pci)={r.funcPci}" + '\r' + '\n';
            }
            textBoxForHalfDivisionMethod.Text += $"Ответ Xmin ={method.minX} f(Xmin)={method.minF}";
            buildgraph(sender, e, a, b, Color.Red);
        }
    }
}
