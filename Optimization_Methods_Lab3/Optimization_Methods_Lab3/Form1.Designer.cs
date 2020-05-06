namespace Optimization_Methods_Lab3
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
            this.speedyDescentMethod = new System.Windows.Forms.Button();
            this.SpeedyDescent = new System.ComponentModel.BackgroundWorker();
            this.textSpeedy = new System.Windows.Forms.TextBox();
            this.stepCrushingMethod = new System.Windows.Forms.Button();
            this.textStepCrushing = new System.Windows.Forms.TextBox();
            this.newtonsMethod = new System.Windows.Forms.Button();
            this.textNewton = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // speedyDescentMethod
            // 
            this.speedyDescentMethod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.speedyDescentMethod.FlatAppearance.BorderSize = 0;
            this.speedyDescentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedyDescentMethod.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedyDescentMethod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.speedyDescentMethod.Location = new System.Drawing.Point(9, 20);
            this.speedyDescentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.speedyDescentMethod.Name = "speedyDescentMethod";
            this.speedyDescentMethod.Size = new System.Drawing.Size(142, 82);
            this.speedyDescentMethod.TabIndex = 0;
            this.speedyDescentMethod.Text = "Метод наискорейшего спуска";
            this.speedyDescentMethod.UseVisualStyleBackColor = false;
            this.speedyDescentMethod.Click += new System.EventHandler(this.speedyDescentMethod_Click);
            // 
            // textSpeedy
            // 
            this.textSpeedy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSpeedy.Location = new System.Drawing.Point(155, 20);
            this.textSpeedy.Margin = new System.Windows.Forms.Padding(2);
            this.textSpeedy.Multiline = true;
            this.textSpeedy.Name = "textSpeedy";
            this.textSpeedy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSpeedy.Size = new System.Drawing.Size(616, 82);
            this.textSpeedy.TabIndex = 1;
            // 
            // stepCrushingMethod
            // 
            this.stepCrushingMethod.BackColor = System.Drawing.Color.Lime;
            this.stepCrushingMethod.FlatAppearance.BorderSize = 0;
            this.stepCrushingMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stepCrushingMethod.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepCrushingMethod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stepCrushingMethod.Location = new System.Drawing.Point(9, 115);
            this.stepCrushingMethod.Margin = new System.Windows.Forms.Padding(2);
            this.stepCrushingMethod.Name = "stepCrushingMethod";
            this.stepCrushingMethod.Size = new System.Drawing.Size(142, 82);
            this.stepCrushingMethod.TabIndex = 2;
            this.stepCrushingMethod.Text = "Метод дробления шага";
            this.stepCrushingMethod.UseVisualStyleBackColor = false;
            this.stepCrushingMethod.Click += new System.EventHandler(this.stepCrushingMethod_Click);
            // 
            // textStepCrushing
            // 
            this.textStepCrushing.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textStepCrushing.Location = new System.Drawing.Point(155, 115);
            this.textStepCrushing.Margin = new System.Windows.Forms.Padding(2);
            this.textStepCrushing.Multiline = true;
            this.textStepCrushing.Name = "textStepCrushing";
            this.textStepCrushing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textStepCrushing.Size = new System.Drawing.Size(616, 82);
            this.textStepCrushing.TabIndex = 3;
            // 
            // newtonsMethod
            // 
            this.newtonsMethod.BackColor = System.Drawing.Color.DarkViolet;
            this.newtonsMethod.FlatAppearance.BorderSize = 0;
            this.newtonsMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newtonsMethod.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newtonsMethod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newtonsMethod.Location = new System.Drawing.Point(9, 211);
            this.newtonsMethod.Margin = new System.Windows.Forms.Padding(2);
            this.newtonsMethod.Name = "newtonsMethod";
            this.newtonsMethod.Size = new System.Drawing.Size(142, 82);
            this.newtonsMethod.TabIndex = 4;
            this.newtonsMethod.Text = "Метод Ньютона";
            this.newtonsMethod.UseVisualStyleBackColor = false;
            // 
            // textNewton
            // 
            this.textNewton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNewton.Location = new System.Drawing.Point(155, 211);
            this.textNewton.Margin = new System.Windows.Forms.Padding(2);
            this.textNewton.Multiline = true;
            this.textNewton.Name = "textNewton";
            this.textNewton.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textNewton.Size = new System.Drawing.Size(616, 82);
            this.textNewton.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 316);
            this.Controls.Add(this.textNewton);
            this.Controls.Add(this.newtonsMethod);
            this.Controls.Add(this.textStepCrushing);
            this.Controls.Add(this.stepCrushingMethod);
            this.Controls.Add(this.textSpeedy);
            this.Controls.Add(this.speedyDescentMethod);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button speedyDescentMethod;
        private System.ComponentModel.BackgroundWorker SpeedyDescent;
        private System.Windows.Forms.TextBox textSpeedy;
        private System.Windows.Forms.Button stepCrushingMethod;
        private System.Windows.Forms.TextBox textStepCrushing;
        private System.Windows.Forms.Button newtonsMethod;
        private System.Windows.Forms.TextBox textNewton;
    }
}

