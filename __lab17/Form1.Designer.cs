namespace __lab17
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rTxtBox_OutputBestStudents = new System.Windows.Forms.RichTextBox();
            this.rTxtBox_OutputReakStudents = new System.Windows.Forms.RichTextBox();
            this.btn_GoOutput = new System.Windows.Forms.Button();
            this.rTxtBox_AverageStudent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Три самых слабых ученика:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Три самых сильных ученика:";
            // 
            // rTxtBox_OutputBestStudents
            // 
            this.rTxtBox_OutputBestStudents.Location = new System.Drawing.Point(12, 169);
            this.rTxtBox_OutputBestStudents.Name = "rTxtBox_OutputBestStudents";
            this.rTxtBox_OutputBestStudents.ReadOnly = true;
            this.rTxtBox_OutputBestStudents.Size = new System.Drawing.Size(222, 125);
            this.rTxtBox_OutputBestStudents.TabIndex = 2;
            this.rTxtBox_OutputBestStudents.Text = "";
            // 
            // rTxtBox_OutputReakStudents
            // 
            this.rTxtBox_OutputReakStudents.Location = new System.Drawing.Point(547, 169);
            this.rTxtBox_OutputReakStudents.Name = "rTxtBox_OutputReakStudents";
            this.rTxtBox_OutputReakStudents.ReadOnly = true;
            this.rTxtBox_OutputReakStudents.Size = new System.Drawing.Size(222, 125);
            this.rTxtBox_OutputReakStudents.TabIndex = 3;
            this.rTxtBox_OutputReakStudents.Text = "";
            // 
            // btn_GoOutput
            // 
            this.btn_GoOutput.Location = new System.Drawing.Point(357, 415);
            this.btn_GoOutput.Name = "btn_GoOutput";
            this.btn_GoOutput.Size = new System.Drawing.Size(90, 23);
            this.btn_GoOutput.TabIndex = 4;
            this.btn_GoOutput.Text = "Вывести";
            this.btn_GoOutput.UseVisualStyleBackColor = true;
            this.btn_GoOutput.Click += new System.EventHandler(this.Btn_GoOutput_Click);
            // 
            // rTxtBox_AverageStudent
            // 
            this.rTxtBox_AverageStudent.Location = new System.Drawing.Point(288, 169);
            this.rTxtBox_AverageStudent.Name = "rTxtBox_AverageStudent";
            this.rTxtBox_AverageStudent.ReadOnly = true;
            this.rTxtBox_AverageStudent.Size = new System.Drawing.Size(222, 125);
            this.rTxtBox_AverageStudent.TabIndex = 6;
            this.rTxtBox_AverageStudent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Средний балл по предметам";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTxtBox_AverageStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_GoOutput);
            this.Controls.Add(this.rTxtBox_OutputReakStudents);
            this.Controls.Add(this.rTxtBox_OutputBestStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rTxtBox_OutputBestStudents;
        private System.Windows.Forms.RichTextBox rTxtBox_OutputReakStudents;
        private System.Windows.Forms.Button btn_GoOutput;
        private System.Windows.Forms.RichTextBox rTxtBox_AverageStudent;
        private System.Windows.Forms.Label label3;
    }
}

