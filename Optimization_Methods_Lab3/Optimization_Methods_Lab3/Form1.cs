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

using Optimization_Methods_Lab3.Models;

using Optimization_Methods_Lab3.Entities.Functions;

namespace Optimization_Methods_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void speedyDescentMethod_Click(object sender, EventArgs e)
        {
            IFunction func = new Misha();
            SpeedyDescentMethod sd = new SpeedyDescentMethod(func);
            textSpeedy.Clear();
            int count = 1;
            textSpeedy.Text += $"Функция {func.getFunciton()} " + '\r' + '\n';
            foreach (Rezult r in sd.rezults)
            {
                textSpeedy.Text += $"Итерация {count++}: x1 = {r.x}  x2 = {r.y}  f = {r.f}" + '\r' + '\n';
            }
        }

        private void stepCrushingMethod_Click(object sender, EventArgs e)
        {
            IFunction func = new Misha();
            StepCrushingMethod cm = new StepCrushingMethod(func);
            textStepCrushing.Clear();
            textStepCrushingRozenbrok.Clear();
            int count = 1;
            int counter = 1;
            textStepCrushing.Text += $"Функция {func.getFunciton()}" + '\r' + '\n';
            foreach (Rezult r in cm.rezults)
            {
                textStepCrushing.Text += $"Итерация {count++}: x1 = {r.x}  x2 = {r.y}  f = {r.f}" + '\r' + '\n';
            }

            textStepCrushingRozenbrok.Text += $"Функция  Розенброка {func.getRozenbrokeFunction()} " + '\r' + '\n';
            foreach (Rezult r in cm.rezultsRoz)
            {
                textStepCrushingRozenbrok.Text += $"Итерация {counter++}: x1 = {r.x}  x2 = {r.y}  f = {r.f}" + '\r' + '\n';
            }

        }
    }

}
