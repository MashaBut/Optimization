namespace OptimizationMethids
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chart1 = new OptimizationMethids.Chart();
            this.btnForHalfDivisionMethod = new System.Windows.Forms.Button();
            this.btnForGoldenRadioMethod = new System.Windows.Forms.Button();
            this.btnForFibonachiMethod = new System.Windows.Forms.Button();
            this.textBoxForHalfDivisionMethod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.textBoxFunction = new System.Windows.Forms.TextBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.epsilon = new System.Windows.Forms.TextBox();
            this.rightBorders = new System.Windows.Forms.TextBox();
            this.leftBorders = new System.Windows.Forms.TextBox();
            this.delta = new System.Windows.Forms.TextBox();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.textBoxForGoldenRadioMethod = new System.Windows.Forms.TextBox();
            this.textBoxForFibonachiMethod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.GridStep = 1D;
            this.chart1.Indent = 20;
            this.chart1.InterpolationStep = 0.01F;
            this.chart1.Location = new System.Drawing.Point(704, 12);
            this.chart1.MaxX = 3F;
            this.chart1.MaxY = 4F;
            this.chart1.MinX = -1F;
            this.chart1.MinY = -4F;
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(454, 511);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnForHalfDivisionMethod
            // 
            this.btnForHalfDivisionMethod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnForHalfDivisionMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnForHalfDivisionMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForHalfDivisionMethod.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForHalfDivisionMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForHalfDivisionMethod.Location = new System.Drawing.Point(12, 160);
            this.btnForHalfDivisionMethod.Name = "btnForHalfDivisionMethod";
            this.btnForHalfDivisionMethod.Size = new System.Drawing.Size(230, 57);
            this.btnForHalfDivisionMethod.TabIndex = 1;
            this.btnForHalfDivisionMethod.Text = "Метод половинного деления";
            this.btnForHalfDivisionMethod.UseVisualStyleBackColor = false;
            // 
            // btnForGoldenRadioMethod
            // 
            this.btnForGoldenRadioMethod.BackColor = System.Drawing.Color.DarkGreen;
            this.btnForGoldenRadioMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnForGoldenRadioMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForGoldenRadioMethod.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForGoldenRadioMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForGoldenRadioMethod.Location = new System.Drawing.Point(251, 160);
            this.btnForGoldenRadioMethod.Name = "btnForGoldenRadioMethod";
            this.btnForGoldenRadioMethod.Size = new System.Drawing.Size(245, 57);
            this.btnForGoldenRadioMethod.TabIndex = 1;
            this.btnForGoldenRadioMethod.Text = "Метод золотого сечения";
            this.btnForGoldenRadioMethod.UseVisualStyleBackColor = false;
            // 
            // btnForFibonachiMethod
            // 
            this.btnForFibonachiMethod.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnForFibonachiMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnForFibonachiMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForFibonachiMethod.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForFibonachiMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForFibonachiMethod.Location = new System.Drawing.Point(502, 160);
            this.btnForFibonachiMethod.Name = "btnForFibonachiMethod";
            this.btnForFibonachiMethod.Size = new System.Drawing.Size(220, 57);
            this.btnForFibonachiMethod.TabIndex = 1;
            this.btnForFibonachiMethod.Text = "Метод Фибоначчи";
            this.btnForFibonachiMethod.UseVisualStyleBackColor = false;
            // 
            // textBoxForHalfDivisionMethod
            // 
            this.textBoxForHalfDivisionMethod.Location = new System.Drawing.Point(12, 223);
            this.textBoxForHalfDivisionMethod.Multiline = true;
            this.textBoxForHalfDivisionMethod.Name = "textBoxForHalfDivisionMethod";
            this.textBoxForHalfDivisionMethod.Size = new System.Drawing.Size(230, 297);
            this.textBoxForHalfDivisionMethod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Функция";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a.Location = new System.Drawing.Point(21, 66);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(23, 25);
            this.a.TabIndex = 3;
            this.a.Text = "a";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b.Location = new System.Drawing.Point(143, 66);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(24, 25);
            this.b.TabIndex = 3;
            this.b.Text = "b";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e.Location = new System.Drawing.Point(16, 122);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(27, 25);
            this.e.TabIndex = 3;
            this.e.Text = " ε";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d.Location = new System.Drawing.Point(139, 120);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(28, 25);
            this.d.TabIndex = 3;
            this.d.Text = " 𝛿";
            // 
            // textBoxFunction
            // 
            this.textBoxFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunction.Location = new System.Drawing.Point(111, 21);
            this.textBoxFunction.Name = "textBoxFunction";
            this.textBoxFunction.Size = new System.Drawing.Size(303, 27);
            this.textBoxFunction.TabIndex = 4;
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "min",
            "max"});
            this.checkedListBox.Location = new System.Drawing.Point(448, 21);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(109, 69);
            this.checkedListBox.TabIndex = 5;
            // 
            // epsilon
            // 
            this.epsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsilon.Location = new System.Drawing.Point(50, 122);
            this.epsilon.Name = "epsilon";
            this.epsilon.Size = new System.Drawing.Size(69, 27);
            this.epsilon.TabIndex = 4;
            // 
            // rightBorders
            // 
            this.rightBorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBorders.Location = new System.Drawing.Point(173, 66);
            this.rightBorders.Name = "rightBorders";
            this.rightBorders.Size = new System.Drawing.Size(69, 27);
            this.rightBorders.TabIndex = 4;
            // 
            // leftBorders
            // 
            this.leftBorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBorders.Location = new System.Drawing.Point(50, 66);
            this.leftBorders.Name = "leftBorders";
            this.leftBorders.Size = new System.Drawing.Size(69, 27);
            this.leftBorders.TabIndex = 4;
            // 
            // delta
            // 
            this.delta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delta.Location = new System.Drawing.Point(173, 120);
            this.delta.Name = "delta";
            this.delta.Size = new System.Drawing.Size(69, 27);
            this.delta.TabIndex = 4;
            // 
            // btnClearChart
            // 
            this.btnClearChart.BackColor = System.Drawing.Color.Crimson;
            this.btnClearChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearChart.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearChart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearChart.Location = new System.Drawing.Point(615, 21);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(98, 64);
            this.btnClearChart.TabIndex = 1;
            this.btnClearChart.Text = "Очистить график";
            this.btnClearChart.UseVisualStyleBackColor = false;
            // 
            // textBoxForGoldenRadioMethod
            // 
            this.textBoxForGoldenRadioMethod.Location = new System.Drawing.Point(251, 223);
            this.textBoxForGoldenRadioMethod.Multiline = true;
            this.textBoxForGoldenRadioMethod.Name = "textBoxForGoldenRadioMethod";
            this.textBoxForGoldenRadioMethod.Size = new System.Drawing.Size(245, 297);
            this.textBoxForGoldenRadioMethod.TabIndex = 2;
            // 
            // textBoxForFibonachiMethod
            // 
            this.textBoxForFibonachiMethod.Location = new System.Drawing.Point(502, 223);
            this.textBoxForFibonachiMethod.Multiline = true;
            this.textBoxForFibonachiMethod.Name = "textBoxForFibonachiMethod";
            this.textBoxForFibonachiMethod.Size = new System.Drawing.Size(220, 297);
            this.textBoxForFibonachiMethod.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1170, 538);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.delta);
            this.Controls.Add(this.leftBorders);
            this.Controls.Add(this.rightBorders);
            this.Controls.Add(this.epsilon);
            this.Controls.Add(this.textBoxFunction);
            this.Controls.Add(this.d);
            this.Controls.Add(this.e);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForFibonachiMethod);
            this.Controls.Add(this.textBoxForGoldenRadioMethod);
            this.Controls.Add(this.textBoxForHalfDivisionMethod);
            this.Controls.Add(this.btnClearChart);
            this.Controls.Add(this.btnForFibonachiMethod);
            this.Controls.Add(this.btnForGoldenRadioMethod);
            this.Controls.Add(this.btnForHalfDivisionMethod);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chart chart1;
        private System.Windows.Forms.Button btnForHalfDivisionMethod;
        private System.Windows.Forms.Button btnForGoldenRadioMethod;
        private System.Windows.Forms.Button btnForFibonachiMethod;
        private System.Windows.Forms.TextBox textBoxForHalfDivisionMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox textBoxFunction;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.TextBox epsilon;
        private System.Windows.Forms.TextBox rightBorders;
        private System.Windows.Forms.TextBox leftBorders;
        private System.Windows.Forms.TextBox delta;
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.TextBox textBoxForGoldenRadioMethod;
        private System.Windows.Forms.TextBox textBoxForFibonachiMethod;
    }
}

