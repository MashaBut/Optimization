using System.Drawing;
using System.Windows.Forms;

namespace OptimizationMethids
{
    public class Chart : Control
    {
        /// Отступы
        public int Indent { get; set; }
        public float MaxX { get; set; }
        public float MinX { get; set; }
        public float MaxY { get; set; }
        public float MinY { get; set; }
        public double GridStep { get; set; }/// Шаг сетки
        public float InterpolationStep { get; set; }/// Шаг интерполирования

        public Chart()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            Indent = 20;
            MinX = -1;
            MaxX = 3;
            MinY = -4;
            MaxY = 4;
            GridStep = 1;
            InterpolationStep = 0.01f;
        }
        public Rectangle ChartArea
        {
            get
            {
                var rect = ClientRectangle;
                rect.Inflate(-Indent, -Indent);
                return rect;
            }

        }

        public float YToPixels(float y)
        {
            return ChartArea.Height * (y - MinY) / (MaxY - MinY);
        }

        public float XToPixels(float x)
        {
            return ChartArea.Width * (x - MinX) / (MaxX - MinX);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var rect = ChartArea;
            var gr = e.Graphics;

            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            var center = new PointF(rect.Left + XToPixels(0), rect.Bottom - YToPixels(0));
            //рисуем сетку
            using (var font = new Font(Font.FontFamily, 6f))
            using (var pen = new Pen(Color.FromArgb(50, Color.Navy), 1))
            {
                for (double x = MinX; x <= MaxX; x += GridStep)
                {
                    if (x != 0)
                    {
                        var absX = rect.Left + XToPixels((float)x);
                        gr.DrawLine(pen, absX, rect.Bottom, absX, rect.Top - 1);
                        gr.DrawString(x.ToString("0"), font, Brushes.Navy, absX - 5, center.Y + 5);
                    }
                }

                for (double y = MinY; y <= MaxY; y += GridStep)
                {
                    if (y != 0)
                    {
                        var absY = rect.Bottom - YToPixels((float)y);
                        gr.DrawLine(pen, rect.Left, absY, rect.Right, absY);
                        gr.DrawString(y.ToString("0"), font, Brushes.Navy, center.X - 15, absY);
                    }
                }
            }

            //рисуем оси
            using (var pen = new Pen(Color.Navy, 1))
            {
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                gr.DrawLine(pen, center.X, rect.Bottom, center.X, rect.Top);
                gr.DrawLine(pen, rect.Left, center.Y, rect.Right, center.Y);
            }

        }

    }
}
