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
            this.SpeedyMethodButton = new System.Windows.Forms.Button();
            this.NewtonMethodButton = new System.Windows.Forms.Button();
            this.GradMethodButton = new System.Windows.Forms.Button();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // speedyDescentMethod
            // 
            this.speedyDescentMethod.Location = new System.Drawing.Point(0, 0);
            this.speedyDescentMethod.Name = "speedyDescentMethod";
            this.speedyDescentMethod.Size = new System.Drawing.Size(75, 23);
            this.speedyDescentMethod.TabIndex = 0;
            // 
            // SpeedyMethodButton
            // 
            this.SpeedyMethodButton.BackColor = System.Drawing.Color.Peru;
            this.SpeedyMethodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeedyMethodButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedyMethodButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SpeedyMethodButton.Location = new System.Drawing.Point(11, 11);
            this.SpeedyMethodButton.Margin = new System.Windows.Forms.Padding(2);
            this.SpeedyMethodButton.Name = "SpeedyMethodButton";
            this.SpeedyMethodButton.Size = new System.Drawing.Size(122, 63);
            this.SpeedyMethodButton.TabIndex = 0;
            this.SpeedyMethodButton.Text = "Метод найшвидшого спуску";
            this.SpeedyMethodButton.UseVisualStyleBackColor = false;
            this.SpeedyMethodButton.Click += new System.EventHandler(this.SpeedyMethodButton_Click);
            // 
            // NewtonMethodButton
            // 
            this.NewtonMethodButton.BackColor = System.Drawing.Color.Green;
            this.NewtonMethodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewtonMethodButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewtonMethodButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewtonMethodButton.Location = new System.Drawing.Point(137, 11);
            this.NewtonMethodButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewtonMethodButton.Name = "NewtonMethodButton";
            this.NewtonMethodButton.Size = new System.Drawing.Size(114, 63);
            this.NewtonMethodButton.TabIndex = 0;
            this.NewtonMethodButton.Text = "Метод ньютона";
            this.NewtonMethodButton.UseVisualStyleBackColor = false;
            this.NewtonMethodButton.Click += new System.EventHandler(this.NewtonMethodButton_Click);
            // 
            // GradMethodButton
            // 
            this.GradMethodButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GradMethodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradMethodButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GradMethodButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GradMethodButton.Location = new System.Drawing.Point(255, 11);
            this.GradMethodButton.Margin = new System.Windows.Forms.Padding(2);
            this.GradMethodButton.Name = "GradMethodButton";
            this.GradMethodButton.Size = new System.Drawing.Size(120, 63);
            this.GradMethodButton.TabIndex = 0;
            this.GradMethodButton.Text = "Градиентный метод";
            this.GradMethodButton.UseVisualStyleBackColor = false;
            this.GradMethodButton.Click += new System.EventHandler(this.GradMethodButton_Click);
            // 
            // ResultListBox
            // 
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.Location = new System.Drawing.Point(12, 79);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(363, 108);
            this.ResultListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 196);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.GradMethodButton);
            this.Controls.Add(this.NewtonMethodButton);
            this.Controls.Add(this.SpeedyMethodButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button speedyDescentMethod;
        private System.ComponentModel.BackgroundWorker SpeedyDescent;
        private System.Windows.Forms.Button SpeedyMethodButton;
        private System.Windows.Forms.Button NewtonMethodButton;
        private System.Windows.Forms.Button GradMethodButton;
        private System.Windows.Forms.ListBox ResultListBox;
    }
}

