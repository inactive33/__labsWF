namespace __lab13
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTxtBox_emailMessage = new System.Windows.Forms.RichTextBox();
            this.btn_OpenEmail = new System.Windows.Forms.Button();
            this.richTxtBox_Email = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(724, 404);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(64, 34);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "*.txt|";
            this.saveFileDialog1.InitialDirectory = "C:\\";
            // 
            // richTxtBox_emailMessage
            // 
            this.richTxtBox_emailMessage.Location = new System.Drawing.Point(246, 89);
            this.richTxtBox_emailMessage.Name = "richTxtBox_emailMessage";
            this.richTxtBox_emailMessage.Size = new System.Drawing.Size(320, 186);
            this.richTxtBox_emailMessage.TabIndex = 3;
            this.richTxtBox_emailMessage.Text = "";
            // 
            // btn_OpenEmail
            // 
            this.btn_OpenEmail.Location = new System.Drawing.Point(466, 295);
            this.btn_OpenEmail.Name = "btn_OpenEmail";
            this.btn_OpenEmail.Size = new System.Drawing.Size(100, 40);
            this.btn_OpenEmail.TabIndex = 4;
            this.btn_OpenEmail.Text = "Open";
            this.btn_OpenEmail.UseVisualStyleBackColor = true;
            this.btn_OpenEmail.Click += new System.EventHandler(this.btn_OpenEmail_Click);
            // 
            // richTxtBox_Email
            // 
            this.richTxtBox_Email.Location = new System.Drawing.Point(246, 61);
            this.richTxtBox_Email.Name = "richTxtBox_Email";
            this.richTxtBox_Email.Size = new System.Drawing.Size(320, 22);
            this.richTxtBox_Email.TabIndex = 5;
            this.richTxtBox_Email.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTxtBox_Email);
            this.Controls.Add(this.btn_OpenEmail);
            this.Controls.Add(this.richTxtBox_emailMessage);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "lab13";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTxtBox_emailMessage;
        private System.Windows.Forms.Button btn_OpenEmail;
        private System.Windows.Forms.RichTextBox richTxtBox_Email;
    }
}

