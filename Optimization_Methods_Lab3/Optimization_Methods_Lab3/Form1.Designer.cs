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
            this.SpeedyDiscent = new System.Windows.Forms.Button();
            this.SpeedyDescent = new System.ComponentModel.BackgroundWorker();
            this.textSpeedy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SpeedyDiscent
            // 
            this.SpeedyDiscent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SpeedyDiscent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeedyDiscent.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedyDiscent.Location = new System.Drawing.Point(12, 12);
            this.SpeedyDiscent.Name = "SpeedyDiscent";
            this.SpeedyDiscent.Size = new System.Drawing.Size(189, 78);
            this.SpeedyDiscent.TabIndex = 0;
            this.SpeedyDiscent.Text = "Метод наискорейшего спуска";
            this.SpeedyDiscent.UseVisualStyleBackColor = false;
            this.SpeedyDiscent.Click += new System.EventHandler(this.SpeedyDiscent_Click);
            // 
            // textSpeedy
            // 
            this.textSpeedy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSpeedy.Location = new System.Drawing.Point(198, 12);
            this.textSpeedy.Multiline = true;
            this.textSpeedy.Name = "textSpeedy";
            this.textSpeedy.Size = new System.Drawing.Size(721, 78);
            this.textSpeedy.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 489);
            this.Controls.Add(this.textSpeedy);
            this.Controls.Add(this.SpeedyDiscent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SpeedyDiscent;
        private System.ComponentModel.BackgroundWorker SpeedyDescent;
        private System.Windows.Forms.TextBox textSpeedy;
    }
}

