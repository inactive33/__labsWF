namespace __lab15
{
    partial class FormMain
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
            this.rTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rTextBox_minValue = new System.Windows.Forms.RichTextBox();
            this.rTextBox_maxValue = new System.Windows.Forms.RichTextBox();
            this.lbl_MinValue = new System.Windows.Forms.Label();
            this.lbl_MaxValue = new System.Windows.Forms.Label();
            this.rTxtBox_length = new System.Windows.Forms.RichTextBox();
            this.lbl_length = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTextBox_Output
            // 
            this.rTextBox_Output.Location = new System.Drawing.Point(18, 54);
            this.rTextBox_Output.Name = "rTextBox_Output";
            this.rTextBox_Output.ReadOnly = true;
            this.rTextBox_Output.Size = new System.Drawing.Size(770, 215);
            this.rTextBox_Output.TabIndex = 3;
            this.rTextBox_Output.Text = "";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(515, 421);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 23);
            this.btn_Generate.TabIndex = 2;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Окно вывода";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задания";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(347, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2.  Сформировать случайную символьную последовательность";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(292, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1. Масштабируемый генератор случайных символов";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rTextBox_minValue
            // 
            this.rTextBox_minValue.Location = new System.Drawing.Point(487, 319);
            this.rTextBox_minValue.Name = "rTextBox_minValue";
            this.rTextBox_minValue.Size = new System.Drawing.Size(119, 29);
            this.rTextBox_minValue.TabIndex = 6;
            this.rTextBox_minValue.Text = "";
            // 
            // rTextBox_maxValue
            // 
            this.rTextBox_maxValue.Location = new System.Drawing.Point(487, 367);
            this.rTextBox_maxValue.Name = "rTextBox_maxValue";
            this.rTextBox_maxValue.Size = new System.Drawing.Size(119, 29);
            this.rTextBox_maxValue.TabIndex = 7;
            this.rTextBox_maxValue.Text = "";
            // 
            // lbl_MinValue
            // 
            this.lbl_MinValue.AutoSize = true;
            this.lbl_MinValue.Location = new System.Drawing.Point(484, 303);
            this.lbl_MinValue.Name = "lbl_MinValue";
            this.lbl_MinValue.Size = new System.Drawing.Size(128, 13);
            this.lbl_MinValue.TabIndex = 8;
            this.lbl_MinValue.Text = "Минимальное значение";
            // 
            // lbl_MaxValue
            // 
            this.lbl_MaxValue.AutoSize = true;
            this.lbl_MaxValue.Location = new System.Drawing.Point(484, 351);
            this.lbl_MaxValue.Name = "lbl_MaxValue";
            this.lbl_MaxValue.Size = new System.Drawing.Size(134, 13);
            this.lbl_MaxValue.TabIndex = 9;
            this.lbl_MaxValue.Text = "Максимальное значение";
            // 
            // rTxtBox_length
            // 
            this.rTxtBox_length.Location = new System.Drawing.Point(636, 319);
            this.rTxtBox_length.Name = "rTxtBox_length";
            this.rTxtBox_length.Size = new System.Drawing.Size(152, 29);
            this.rTxtBox_length.TabIndex = 10;
            this.rTxtBox_length.Text = "";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(633, 303);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(155, 13);
            this.lbl_length.TabIndex = 11;
            this.lbl_length.Text = "Максимальная длина строки";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_length);
            this.Controls.Add(this.rTxtBox_length);
            this.Controls.Add(this.lbl_MaxValue);
            this.Controls.Add(this.lbl_MinValue);
            this.Controls.Add(this.rTextBox_maxValue);
            this.Controls.Add(this.rTextBox_minValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rTextBox_Output);
            this.Controls.Add(this.btn_Generate);
            this.Name = "FormMain";
            this.Text = "Масштабируемый генератор случайных символов";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTextBox_Output;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RichTextBox rTextBox_minValue;
        private System.Windows.Forms.RichTextBox rTextBox_maxValue;
        private System.Windows.Forms.Label lbl_MinValue;
        private System.Windows.Forms.Label lbl_MaxValue;
        private System.Windows.Forms.RichTextBox rTxtBox_length;
        private System.Windows.Forms.Label lbl_length;
    }
}

