using Optimization_Methods_Lab3.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimization_Methods_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        }

        //public void buildpointForSpeedyDescent(double a, double b, Color C)
        //{
        //    Graphics g = chart.CreateGraphics();
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        //    float W = chart.Width, H = chart.Height; //w-ширина
        //    Pen RedPen = new Pen(C, 2);

        //}

        //public void buildgraph(double a, double b, Color C)
        //{
        //    Graphics g = chart.CreateGraphics();
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        //    float W = chart.Width, H = chart.Height; //w-ширина
        //    Pen RedPen = new Pen(C, 2);
        //    List<PointF> Points = new List<PointF>();
        //    double y, xx, yy, x1, y1, x2, y2;
        //    double count = 0;
        //    for (double x = a; x <= b; x += 0.1)
        //    {
        //        y = func(x);
        //        xx = W / 2 + x * 41;
        //        yy = H / 2 - y * 41;
        //        PointF point = new PointF((float)xx, (float)yy);
        //        Points.Add(point);
        //        count++;
        //    }
        //    x1 = Points[0].X;
        //    y1 = Points[0].Y;
        //    for (int i = 1; i <= count - 1; i++)
        //    {
        //        x2 = Points[i].X;
        //        y2 = Points[i].Y;
        //        try
        //        {
        //            g.DrawLine(RedPen, (float)x1, (float)y1, (float)x2, (float)y2);
        //        }
        //        catch { }
        //        x1 = x2;
        //        y1 = y2;
        //    }
        //}

        private void SpeedyDiscent_Click(object sender, EventArgs e)
        {
            IFunction func = new Masha();
            SpeedyDescentMethod sd = new SpeedyDescentMethod(func);
            //  chart1.Series[0].Points.Add
            int i = 0;
            foreach(Direction d in sd.points){
                chart1.Series[0].Points.AddXY(d.x1, d.x2);
                chart1.Series[0].Points[i].Color = Color.Red;
         //       chart1.Series[0].Points[i].MarkerStyle


                i++;
            }
        }
    }

}
