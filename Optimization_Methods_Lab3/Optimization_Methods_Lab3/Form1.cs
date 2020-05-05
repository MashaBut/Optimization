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
        }

      

        private void SpeedyDiscent_Click(object sender, EventArgs e)
        {
            IFunction func = new Nastya();
            SpeedyDescentMethod sd = new SpeedyDescentMethod(func);
            textSpeedy.Clear();
            int count = 1;
            textSpeedy.Text += $"Функция {func.getFunciton()} "+ '\r' + '\n';
            foreach (Rezult r in sd.rezults)
            {
                textSpeedy.Text += $"Итерация {count++}: x1 = {r.x}  x2 = {r.y}  f = {r.f}" + '\r' + '\n';
            }
        }
    }

}
