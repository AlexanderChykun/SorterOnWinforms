namespace WinFormsSorter
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.lblEnterArr = new System.Windows.Forms.Label();
            this.tbEnterArr = new System.Windows.Forms.TextBox();
            this.chkbxChooseEnteringMethod = new System.Windows.Forms.CheckBox();
            this.tbNumOfElems = new System.Windows.Forms.TextBox();
            this.lblNumOfElems = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStartSort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.rBtnShell = new System.Windows.Forms.RadioButton();
            this.rBtnQuick = new System.Windows.Forms.RadioButton();
            this.rBtnInsert = new System.Windows.Forms.RadioButton();
            this.rBtnHeap = new System.Windows.Forms.RadioButton();
            this.rBtnCoctail = new System.Windows.Forms.RadioButton();
            this.rBtnBubble = new System.Windows.Forms.RadioButton();
            this.tbSortedArr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterArr
            // 
            this.lblEnterArr.AutoSize = true;
            this.lblEnterArr.Location = new System.Drawing.Point(9, 7);
            this.lblEnterArr.Name = "lblEnterArr";
            this.lblEnterArr.Size = new System.Drawing.Size(170, 13);
            this.lblEnterArr.TabIndex = 0;
            this.lblEnterArr.Text = "Введите массив (через пробел):";
            // 
            // tbEnterArr
            // 
            this.tbEnterArr.Location = new System.Drawing.Point(12, 23);
            this.tbEnterArr.Name = "tbEnterArr";
            this.tbEnterArr.Size = new System.Drawing.Size(456, 20);
            this.tbEnterArr.TabIndex = 1;
            // 
            // chkbxChooseEnteringMethod
            // 
            this.chkbxChooseEnteringMethod.AutoSize = true;
            this.chkbxChooseEnteringMethod.Location = new System.Drawing.Point(12, 50);
            this.chkbxChooseEnteringMethod.Name = "chkbxChooseEnteringMethod";
            this.chkbxChooseEnteringMethod.Size = new System.Drawing.Size(174, 17);
            this.chkbxChooseEnteringMethod.TabIndex = 2;
            this.chkbxChooseEnteringMethod.Text = "Заполнить массив рандомно";
            this.chkbxChooseEnteringMethod.UseVisualStyleBackColor = true;
            this.chkbxChooseEnteringMethod.CheckedChanged += new System.EventHandler(this.chkbxChooseEnteringMethod_CheckedChanged);
            // 
            // tbNumOfElems
            // 
            this.tbNumOfElems.Location = new System.Drawing.Point(218, 50);
            this.tbNumOfElems.Name = "tbNumOfElems";
            this.tbNumOfElems.Size = new System.Drawing.Size(100, 20);
            this.tbNumOfElems.TabIndex = 3;
            // 
            // lblNumOfElems
            // 
            this.lblNumOfElems.AutoSize = true;
            this.lblNumOfElems.Location = new System.Drawing.Point(325, 50);
            this.lblNumOfElems.Name = "lblNumOfElems";
            this.lblNumOfElems.Size = new System.Drawing.Size(220, 13);
            this.lblNumOfElems.TabIndex = 4;
            this.lblNumOfElems.Text = "- введите количество элементов массива";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(488, 23);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.label8);
            this.gbOptions.Controls.Add(this.tbSortedArr);
            this.gbOptions.Controls.Add(this.label7);
            this.gbOptions.Controls.Add(this.label6);
            this.gbOptions.Controls.Add(this.label5);
            this.gbOptions.Controls.Add(this.label4);
            this.gbOptions.Controls.Add(this.label3);
            this.gbOptions.Controls.Add(this.label2);
            this.gbOptions.Controls.Add(this.lblStartSort);
            this.gbOptions.Controls.Add(this.label1);
            this.gbOptions.Controls.Add(this.btnSort);
            this.gbOptions.Controls.Add(this.rBtnShell);
            this.gbOptions.Controls.Add(this.rBtnQuick);
            this.gbOptions.Controls.Add(this.rBtnInsert);
            this.gbOptions.Controls.Add(this.rBtnHeap);
            this.gbOptions.Controls.Add(this.rBtnCoctail);
            this.gbOptions.Controls.Add(this.rBtnBubble);
            this.gbOptions.Location = new System.Drawing.Point(12, 83);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(551, 241);
            this.gbOptions.TabIndex = 6;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Сортировка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сравниваемые элементы:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Перемещаемые элементы:";
            // 
            // lblStartSort
            // 
            this.lblStartSort.AutoSize = true;
            this.lblStartSort.Location = new System.Drawing.Point(270, 35);
            this.lblStartSort.Name = "lblStartSort";
            this.lblStartSort.Size = new System.Drawing.Size(0, 13);
            this.lblStartSort.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Состояние сортировки";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(140, 20);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 133);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "SORT";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // rBtnShell
            // 
            this.rBtnShell.AutoSize = true;
            this.rBtnShell.Location = new System.Drawing.Point(6, 136);
            this.rBtnShell.Name = "rBtnShell";
            this.rBtnShell.Size = new System.Drawing.Size(77, 17);
            this.rBtnShell.TabIndex = 5;
            this.rBtnShell.Text = "Shell sorter";
            this.rBtnShell.UseVisualStyleBackColor = true;
            this.rBtnShell.CheckedChanged += new System.EventHandler(this.rBtnShell_CheckedChanged);
            // 
            // rBtnQuick
            // 
            this.rBtnQuick.AutoSize = true;
            this.rBtnQuick.Location = new System.Drawing.Point(6, 113);
            this.rBtnQuick.Name = "rBtnQuick";
            this.rBtnQuick.Size = new System.Drawing.Size(82, 17);
            this.rBtnQuick.TabIndex = 4;
            this.rBtnQuick.Text = "Quick sorter";
            this.rBtnQuick.UseVisualStyleBackColor = true;
            this.rBtnQuick.CheckedChanged += new System.EventHandler(this.rBtnQuick_CheckedChanged);
            // 
            // rBtnInsert
            // 
            this.rBtnInsert.AutoSize = true;
            this.rBtnInsert.Location = new System.Drawing.Point(6, 90);
            this.rBtnInsert.Name = "rBtnInsert";
            this.rBtnInsert.Size = new System.Drawing.Size(80, 17);
            this.rBtnInsert.TabIndex = 3;
            this.rBtnInsert.Text = "Insert sorter";
            this.rBtnInsert.UseVisualStyleBackColor = true;
            this.rBtnInsert.CheckedChanged += new System.EventHandler(this.rBtnInsert_CheckedChanged);
            // 
            // rBtnHeap
            // 
            this.rBtnHeap.AutoSize = true;
            this.rBtnHeap.Location = new System.Drawing.Point(6, 67);
            this.rBtnHeap.Name = "rBtnHeap";
            this.rBtnHeap.Size = new System.Drawing.Size(80, 17);
            this.rBtnHeap.TabIndex = 2;
            this.rBtnHeap.Text = "Heap sorter";
            this.rBtnHeap.UseVisualStyleBackColor = true;
            this.rBtnHeap.CheckedChanged += new System.EventHandler(this.rBtnHeap_CheckedChanged);
            // 
            // rBtnCoctail
            // 
            this.rBtnCoctail.AutoSize = true;
            this.rBtnCoctail.Location = new System.Drawing.Point(7, 44);
            this.rBtnCoctail.Name = "rBtnCoctail";
            this.rBtnCoctail.Size = new System.Drawing.Size(86, 17);
            this.rBtnCoctail.TabIndex = 1;
            this.rBtnCoctail.Text = "Coctail sorter";
            this.rBtnCoctail.UseVisualStyleBackColor = true;
            this.rBtnCoctail.CheckedChanged += new System.EventHandler(this.rBtnCoctail_CheckedChanged);
            // 
            // rBtnBubble
            // 
            this.rBtnBubble.AutoSize = true;
            this.rBtnBubble.Location = new System.Drawing.Point(7, 20);
            this.rBtnBubble.Name = "rBtnBubble";
            this.rBtnBubble.Size = new System.Drawing.Size(87, 17);
            this.rBtnBubble.TabIndex = 0;
            this.rBtnBubble.Text = "Bubble sorter";
            this.rBtnBubble.UseVisualStyleBackColor = true;
            this.rBtnBubble.CheckedChanged += new System.EventHandler(this.rBtnBubble_CheckedChanged);
            // 
            // tbSortedArr
            // 
            this.tbSortedArr.Location = new System.Drawing.Point(6, 206);
            this.tbSortedArr.Name = "tbSortedArr";
            this.tbSortedArr.Size = new System.Drawing.Size(449, 20);
            this.tbSortedArr.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Отсортированный массив:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblNumOfElems);
            this.Controls.Add(this.tbNumOfElems);
            this.Controls.Add(this.chkbxChooseEnteringMethod);
            this.Controls.Add(this.tbEnterArr);
            this.Controls.Add(this.lblEnterArr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Сортировщик числовых массивов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterArr;
        private System.Windows.Forms.TextBox tbEnterArr;
        private System.Windows.Forms.CheckBox chkbxChooseEnteringMethod;
        private System.Windows.Forms.TextBox tbNumOfElems;
        private System.Windows.Forms.Label lblNumOfElems;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rBtnShell;
        private System.Windows.Forms.RadioButton rBtnQuick;
        private System.Windows.Forms.RadioButton rBtnInsert;
        private System.Windows.Forms.RadioButton rBtnHeap;
        private System.Windows.Forms.RadioButton rBtnCoctail;
        private System.Windows.Forms.RadioButton rBtnBubble;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblStartSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSortedArr;
    }
}

