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
using Optimization_Methods_Lab3.Entities;
using Optimization_Methods_Lab3.Infrastructure;
using Optimization_Methods_Lab3.Entities.Functions;

namespace Optimization_Methods_Lab3
{
    public partial class Form1 : Form
    {
        private FunctionBuilder funcBuilder = new FunctionBuilder(Variant.MISHA);
        public Form1()
        {
            InitializeComponent();
        }

        private void GradMethodButton_Click(object sender, EventArgs e)
        {
            calculate(new StepCrushingMethod());
        }

        private void NewtonMethodButton_Click(object sender, EventArgs e)
        {
            calculate(new NewtonMethod());
        }

        private void SpeedyMethodButton_Click(object sender, EventArgs e)
        {
            calculate(new SpeedyDescentMethod());
        }

        private void calculate(IMethod method)
        {
            showResults(method.getResults(funcBuilder.buildPolyFunction(), 0,0,0.001));
        }

        private void showResults(List<string> results)
        {
            ResultListBox.Items.Clear();
            results.ForEach((String item) => ResultListBox.Items.Add(item));
        }
    }

}
