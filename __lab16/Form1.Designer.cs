namespace __lab16
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
            this.Btn_Calculate = new System.Windows.Forms.Button();
            this.lbl_height = new System.Windows.Forms.Label();
            this.rTxtBox_height = new System.Windows.Forms.RichTextBox();
            this.rTxtBox_time = new System.Windows.Forms.RichTextBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.rTxtBox_Output = new System.Windows.Forms.RichTextBox();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.Location = new System.Drawing.Point(114, 75);
            this.Btn_Calculate.Name = "Btn_Calculate";
            this.Btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.Btn_Calculate.TabIndex = 0;
            this.Btn_Calculate.Text = "Calculate";
            this.Btn_Calculate.UseVisualStyleBackColor = true;
            this.Btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(23, 24);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(48, 13);
            this.lbl_height.TabIndex = 1;
            this.lbl_height.Text = "Высота:";
            // 
            // rTxtBox_height
            // 
            this.rTxtBox_height.Location = new System.Drawing.Point(77, 21);
            this.rTxtBox_height.Name = "rTxtBox_height";
            this.rTxtBox_height.Size = new System.Drawing.Size(680, 22);
            this.rTxtBox_height.TabIndex = 2;
            this.rTxtBox_height.Text = "";
            // 
            // rTxtBox_time
            // 
            this.rTxtBox_time.Location = new System.Drawing.Point(77, 47);
            this.rTxtBox_time.Name = "rTxtBox_time";
            this.rTxtBox_time.Size = new System.Drawing.Size(680, 22);
            this.rTxtBox_time.TabIndex = 4;
            this.rTxtBox_time.Text = "";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(23, 50);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(43, 13);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Время:";
            // 
            // rTxtBox_Output
            // 
            this.rTxtBox_Output.Location = new System.Drawing.Point(12, 143);
            this.rTxtBox_Output.Name = "rTxtBox_Output";
            this.rTxtBox_Output.ReadOnly = true;
            this.rTxtBox_Output.Size = new System.Drawing.Size(745, 295);
            this.rTxtBox_Output.TabIndex = 5;
            this.rTxtBox_Output.Text = "";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(12, 127);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(77, 13);
            this.lbl_Output.TabIndex = 6;
            this.lbl_Output.Text = "Окно вывода:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.rTxtBox_Output);
            this.Controls.Add(this.rTxtBox_time);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.rTxtBox_height);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.Btn_Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Calculate;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.RichTextBox rTxtBox_height;
        private System.Windows.Forms.RichTextBox rTxtBox_time;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.RichTextBox rTxtBox_Output;
        private System.Windows.Forms.Label lbl_Output;
    }
}

