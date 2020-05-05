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
            this.btnForHalfDivisionMethod = new System.Windows.Forms.Button();
            this.btnForGoldenRadioMethod = new System.Windows.Forms.Button();
            this.btnForFibonachiMethod = new System.Windows.Forms.Button();
            this.textBoxForHalfDivisionMethod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.epsilon = new System.Windows.Forms.TextBox();
            this.rightBorders = new System.Windows.Forms.TextBox();
            this.leftBorders = new System.Windows.Forms.TextBox();
            this.delta = new System.Windows.Forms.TextBox();
            this.textBoxForGoldenRadioMethod = new System.Windows.Forms.TextBox();
            this.textBoxForFibonachiMethod = new System.Windows.Forms.TextBox();
            this.chart = new OptimizationMethids.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnForHalfDivisionMethod
            // 
            this.btnForHalfDivisionMethod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnForHalfDivisionMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnForHalfDivisionMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForHalfDivisionMethod.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForHalfDivisionMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForHalfDivisionMethod.Location = new System.Drawing.Point(382, 296);
            this.btnForHalfDivisionMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnForHalfDivisionMethod.Name = "btnForHalfDivisionMethod";
            this.btnForHalfDivisionMethod.Size = new System.Drawing.Size(165, 150);
            this.btnForHalfDivisionMethod.TabIndex = 1;
            this.btnForHalfDivisionMethod.Text = "Метод половинного деления";
            this.btnForHalfDivisionMethod.UseVisualStyleBackColor = false;
            this.btnForHalfDivisionMethod.Click += new System.EventHandler(this.btnForHalfDivisionMethod_Click_1);
            // 
            // btnForGoldenRadioMethod
            // 
            this.btnForGoldenRadioMethod.BackColor = System.Drawing.Color.DarkGreen;
            this.btnForGoldenRadioMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnForGoldenRadioMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForGoldenRadioMethod.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForGoldenRadioMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForGoldenRadioMethod.Location = new System.Drawing.Point(382, 17);
            this.btnForGoldenRadioMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnForGoldenRadioMethod.Name = "btnForGoldenRadioMethod";
            this.btnForGoldenRadioMethod.Size = new System.Drawing.Size(165, 125);
            this.btnForGoldenRadioMethod.TabIndex = 1;
            this.btnForGoldenRadioMethod.Text = "Метод золотого сечения";
            this.btnForGoldenRadioMethod.UseVisualStyleBackColor = false;
            this.btnForGoldenRadioMethod.Click += new System.EventHandler(this.btnForGoldenRadioMethod_Click);
            // 
            // btnForFibonachiMethod
            // 
            this.btnForFibonachiMethod.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnForFibonachiMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnForFibonachiMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForFibonachiMethod.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForFibonachiMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForFibonachiMethod.Location = new System.Drawing.Point(382, 146);
            this.btnForFibonachiMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnForFibonachiMethod.Name = "btnForFibonachiMethod";
            this.btnForFibonachiMethod.Size = new System.Drawing.Size(165, 145);
            this.btnForFibonachiMethod.TabIndex = 1;
            this.btnForFibonachiMethod.Text = "Метод Фибоначчи";
            this.btnForFibonachiMethod.UseVisualStyleBackColor = false;
            this.btnForFibonachiMethod.Click += new System.EventHandler(this.btnForFibonachiMethod_Click);
            // 
            // textBoxForHalfDivisionMethod
            // 
            this.textBoxForHalfDivisionMethod.Location = new System.Drawing.Point(551, 296);
            this.textBoxForHalfDivisionMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxForHalfDivisionMethod.Multiline = true;
            this.textBoxForHalfDivisionMethod.Name = "textBoxForHalfDivisionMethod";
            this.textBoxForHalfDivisionMethod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForHalfDivisionMethod.Size = new System.Drawing.Size(465, 150);
            this.textBoxForHalfDivisionMethod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Функция";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a.Location = new System.Drawing.Point(11, 41);
            this.a.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(17, 20);
            this.a.TabIndex = 3;
            this.a.Text = "a";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b.Location = new System.Drawing.Point(92, 41);
            this.b.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(19, 20);
            this.b.TabIndex = 3;
            this.b.Text = "b";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e.Location = new System.Drawing.Point(8, 69);
            this.e.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(23, 21);
            this.e.TabIndex = 3;
            this.e.Text = " ε";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d.Location = new System.Drawing.Point(87, 69);
            this.d.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(24, 21);
            this.d.TabIndex = 3;
            this.d.Text = " 𝛿";
            // 
            // epsilon
            // 
            this.epsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsilon.Location = new System.Drawing.Point(32, 69);
            this.epsilon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.epsilon.Name = "epsilon";
            this.epsilon.Size = new System.Drawing.Size(53, 23);
            this.epsilon.TabIndex = 4;
            // 
            // rightBorders
            // 
            this.rightBorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBorders.Location = new System.Drawing.Point(115, 40);
            this.rightBorders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightBorders.Name = "rightBorders";
            this.rightBorders.Size = new System.Drawing.Size(53, 23);
            this.rightBorders.TabIndex = 4;
            // 
            // leftBorders
            // 
            this.leftBorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBorders.Location = new System.Drawing.Point(32, 40);
            this.leftBorders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftBorders.Name = "leftBorders";
            this.leftBorders.Size = new System.Drawing.Size(53, 23);
            this.leftBorders.TabIndex = 4;
            // 
            // delta
            // 
            this.delta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delta.Location = new System.Drawing.Point(115, 70);
            this.delta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delta.Name = "delta";
            this.delta.Size = new System.Drawing.Size(53, 23);
            this.delta.TabIndex = 4;
            // 
            // textBoxForGoldenRadioMethod
            // 
            this.textBoxForGoldenRadioMethod.Location = new System.Drawing.Point(551, 17);
            this.textBoxForGoldenRadioMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxForGoldenRadioMethod.Multiline = true;
            this.textBoxForGoldenRadioMethod.Name = "textBoxForGoldenRadioMethod";
            this.textBoxForGoldenRadioMethod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForGoldenRadioMethod.Size = new System.Drawing.Size(465, 125);
            this.textBoxForGoldenRadioMethod.TabIndex = 2;
            // 
            // textBoxForFibonachiMethod
            // 
            this.textBoxForFibonachiMethod.Location = new System.Drawing.Point(551, 146);
            this.textBoxForFibonachiMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxForFibonachiMethod.Multiline = true;
            this.textBoxForFibonachiMethod.Name = "textBoxForFibonachiMethod";
            this.textBoxForFibonachiMethod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForFibonachiMethod.Size = new System.Drawing.Size(462, 145);
            this.textBoxForFibonachiMethod.TabIndex = 2;
            // 
            // chart
            // 
            this.chart.GridStep = 1D;
            this.chart.Indent = 20;
            this.chart.InterpolationStep = 0.01F;
            this.chart.Location = new System.Drawing.Point(3, 97);
            this.chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart.MaxX = 4F;
            this.chart.MaxY = 4F;
            this.chart.MinX = -4F;
            this.chart.MinY = -4F;
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(375, 368);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(178, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "n";
            // 
            // nTextBox
            // 
            this.nTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nTextBox.Location = new System.Drawing.Point(202, 70);
            this.nTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(53, 23);
            this.nTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 467);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.delta);
            this.Controls.Add(this.leftBorders);
            this.Controls.Add(this.rightBorders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.epsilon);
            this.Controls.Add(this.d);
            this.Controls.Add(this.e);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForFibonachiMethod);
            this.Controls.Add(this.textBoxForGoldenRadioMethod);
            this.Controls.Add(this.textBoxForHalfDivisionMethod);
            this.Controls.Add(this.btnForFibonachiMethod);
            this.Controls.Add(this.btnForGoldenRadioMethod);
            this.Controls.Add(this.btnForHalfDivisionMethod);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnForHalfDivisionMethod;
        private System.Windows.Forms.Button btnForGoldenRadioMethod;
        private System.Windows.Forms.Button btnForFibonachiMethod;
        private System.Windows.Forms.TextBox textBoxForHalfDivisionMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox epsilon;
        private System.Windows.Forms.TextBox rightBorders;
        private System.Windows.Forms.TextBox leftBorders;
        private System.Windows.Forms.TextBox delta;
        private System.Windows.Forms.TextBox textBoxForGoldenRadioMethod;
        private System.Windows.Forms.TextBox textBoxForFibonachiMethod;
        private Chart chart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nTextBox;
    }
}

