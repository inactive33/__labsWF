namespace __lab14
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.RtxtBox_ArrayText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GenerateForBubbleArray = new System.Windows.Forms.Button();
            this.btn_SortBubble = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTxtBox_target = new System.Windows.Forms.RichTextBox();
            this.richTxtBox_LineArray = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CreateLineArray = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdButton_Line = new System.Windows.Forms.RadioButton();
            this.rdButton_Binary = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.radioButton_InsertSort = new System.Windows.Forms.RadioButton();
            this.radioButton_bubbleSort = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_ChooseSort = new System.Windows.Forms.RadioButton();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.btn_SortBubble);
            this.tabPage3.Controls.Add(this.btn_GenerateForBubbleArray);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.RtxtBox_ArrayText);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пузырьковый, вставками, выбором";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Массив:";
            // 
            // RtxtBox_ArrayText
            // 
            this.RtxtBox_ArrayText.Location = new System.Drawing.Point(78, 184);
            this.RtxtBox_ArrayText.Name = "RtxtBox_ArrayText";
            this.RtxtBox_ArrayText.ReadOnly = true;
            this.RtxtBox_ArrayText.Size = new System.Drawing.Size(598, 102);
            this.RtxtBox_ArrayText.TabIndex = 9;
            this.RtxtBox_ArrayText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(124, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(598, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сортировки пузырьком, вставками и выбором";
            // 
            // btn_GenerateForBubbleArray
            // 
            this.btn_GenerateForBubbleArray.Location = new System.Drawing.Point(682, 264);
            this.btn_GenerateForBubbleArray.Name = "btn_GenerateForBubbleArray";
            this.btn_GenerateForBubbleArray.Size = new System.Drawing.Size(97, 22);
            this.btn_GenerateForBubbleArray.TabIndex = 11;
            this.btn_GenerateForBubbleArray.Text = "Сгенерировать";
            this.btn_GenerateForBubbleArray.UseVisualStyleBackColor = true;
            this.btn_GenerateForBubbleArray.Click += new System.EventHandler(this.Btn_GenerateArray_Click);
            // 
            // btn_SortBubble
            // 
            this.btn_SortBubble.Location = new System.Drawing.Point(168, 363);
            this.btn_SortBubble.Name = "btn_SortBubble";
            this.btn_SortBubble.Size = new System.Drawing.Size(100, 23);
            this.btn_SortBubble.TabIndex = 12;
            this.btn_SortBubble.Text = "Отсортировать";
            this.btn_SortBubble.UseVisualStyleBackColor = true;
            this.btn_SortBubble.Click += new System.EventHandler(this.Btn_Sort_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btn_CreateLineArray);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.richTxtBox_LineArray);
            this.tabPage1.Controls.Add(this.richTxtBox_target);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Линейный и бинарный";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число для поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Массив:";
            // 
            // richTxtBox_target
            // 
            this.richTxtBox_target.Location = new System.Drawing.Point(192, 364);
            this.richTxtBox_target.Name = "richTxtBox_target";
            this.richTxtBox_target.Size = new System.Drawing.Size(145, 21);
            this.richTxtBox_target.TabIndex = 0;
            this.richTxtBox_target.Text = "";
            // 
            // richTxtBox_LineArray
            // 
            this.richTxtBox_LineArray.Location = new System.Drawing.Point(72, 213);
            this.richTxtBox_LineArray.Name = "richTxtBox_LineArray";
            this.richTxtBox_LineArray.ReadOnly = true;
            this.richTxtBox_LineArray.Size = new System.Drawing.Size(598, 102);
            this.richTxtBox_LineArray.TabIndex = 3;
            this.richTxtBox_LineArray.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(186, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Линейный и бинарный способ";
            // 
            // btn_CreateLineArray
            // 
            this.btn_CreateLineArray.Location = new System.Drawing.Point(676, 293);
            this.btn_CreateLineArray.Name = "btn_CreateLineArray";
            this.btn_CreateLineArray.Size = new System.Drawing.Size(97, 22);
            this.btn_CreateLineArray.TabIndex = 6;
            this.btn_CreateLineArray.Text = "Сгенерировать";
            this.btn_CreateLineArray.UseVisualStyleBackColor = true;
            this.btn_CreateLineArray.Click += new System.EventHandler(this.Btn_CreateLineArray_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_FindNumber_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdButton_Binary);
            this.groupBox1.Controls.Add(this.rdButton_Line);
            this.groupBox1.Location = new System.Drawing.Point(424, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите способ";
            // 
            // rdButton_Line
            // 
            this.rdButton_Line.AutoSize = true;
            this.rdButton_Line.Location = new System.Drawing.Point(7, 20);
            this.rdButton_Line.Name = "rdButton_Line";
            this.rdButton_Line.Size = new System.Drawing.Size(116, 17);
            this.rdButton_Line.TabIndex = 0;
            this.rdButton_Line.TabStop = true;
            this.rdButton_Line.Text = "Линейный способ";
            this.rdButton_Line.UseVisualStyleBackColor = true;
            // 
            // rdButton_Binary
            // 
            this.rdButton_Binary.AutoSize = true;
            this.rdButton_Binary.Location = new System.Drawing.Point(7, 43);
            this.rdButton_Binary.Name = "rdButton_Binary";
            this.rdButton_Binary.Size = new System.Drawing.Size(115, 17);
            this.rdButton_Binary.TabIndex = 1;
            this.rdButton_Binary.TabStop = true;
            this.rdButton_Binary.Text = "Бинарный способ";
            this.rdButton_Binary.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 425);
            this.tabControl1.TabIndex = 1;
            // 
            // radioButton_InsertSort
            // 
            this.radioButton_InsertSort.AutoSize = true;
            this.radioButton_InsertSort.Location = new System.Drawing.Point(7, 43);
            this.radioButton_InsertSort.Name = "radioButton_InsertSort";
            this.radioButton_InsertSort.Size = new System.Drawing.Size(143, 17);
            this.radioButton_InsertSort.TabIndex = 1;
            this.radioButton_InsertSort.TabStop = true;
            this.radioButton_InsertSort.Text = "Сортировка вставками";
            this.radioButton_InsertSort.UseVisualStyleBackColor = true;
            // 
            // radioButton_bubbleSort
            // 
            this.radioButton_bubbleSort.AutoSize = true;
            this.radioButton_bubbleSort.Location = new System.Drawing.Point(7, 20);
            this.radioButton_bubbleSort.Name = "radioButton_bubbleSort";
            this.radioButton_bubbleSort.Size = new System.Drawing.Size(145, 17);
            this.radioButton_bubbleSort.TabIndex = 0;
            this.radioButton_bubbleSort.TabStop = true;
            this.radioButton_bubbleSort.Text = "Сортировка пузырьком";
            this.radioButton_bubbleSort.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_ChooseSort);
            this.groupBox2.Controls.Add(this.radioButton_InsertSort);
            this.groupBox2.Controls.Add(this.radioButton_bubbleSort);
            this.groupBox2.Location = new System.Drawing.Point(9, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 89);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите способ";
            // 
            // radioButton_ChooseSort
            // 
            this.radioButton_ChooseSort.AutoSize = true;
            this.radioButton_ChooseSort.Location = new System.Drawing.Point(7, 65);
            this.radioButton_ChooseSort.Name = "radioButton_ChooseSort";
            this.radioButton_ChooseSort.Size = new System.Drawing.Size(134, 17);
            this.radioButton_ChooseSort.TabIndex = 2;
            this.radioButton_ChooseSort.TabStop = true;
            this.radioButton_ChooseSort.Text = "Сортировка выбором";
            this.radioButton_ChooseSort.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "lab14";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_SortBubble;
        private System.Windows.Forms.Button btn_GenerateForBubbleArray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RtxtBox_ArrayText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdButton_Binary;
        private System.Windows.Forms.RadioButton rdButton_Line;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_CreateLineArray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTxtBox_LineArray;
        private System.Windows.Forms.RichTextBox richTxtBox_target;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_ChooseSort;
        private System.Windows.Forms.RadioButton radioButton_InsertSort;
        private System.Windows.Forms.RadioButton radioButton_bubbleSort;
    }
}

