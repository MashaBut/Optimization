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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedyDescentMethod
            // 
            this.SpeedyDiscent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SpeedyDiscent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeedyDiscent.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedyDiscent.Location = new System.Drawing.Point(9, 10);
            this.SpeedyDiscent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpeedyDiscent.Name = "SpeedyDiscent";
            this.SpeedyDiscent.Size = new System.Drawing.Size(142, 63);
            this.SpeedyDiscent.TabIndex = 0;
            this.SpeedyDiscent.Text = "Метод наискорейшего спуска";
            this.SpeedyDiscent.UseVisualStyleBackColor = false;
            this.SpeedyDiscent.Click += new System.EventHandler(this.SpeedyDiscent_Click);
            // 
            // textSpeedy
            // 
            this.textSpeedy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSpeedy.Location = new System.Drawing.Point(148, 10);
            this.textSpeedy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSpeedy.Multiline = true;
            this.textSpeedy.Name = "textSpeedy";
            this.textSpeedy.Size = new System.Drawing.Size(542, 64);
            this.textSpeedy.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(9, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Метод ньютона";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NewtonButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 397);
            this.Controls.Add(this.textSpeedy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SpeedyDiscent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
    }
}

