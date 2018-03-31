namespace Projem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Satır = new System.Windows.Forms.ComboBox();
            this.Sutun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sutun2 = new System.Windows.Forms.ComboBox();
            this.Satır2 = new System.Windows.Forms.ComboBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radio6 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.radio10 = new System.Windows.Forms.RadioButton();
            this.radio9 = new System.Windows.Forms.RadioButton();
            this.Carp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radio7 = new System.Windows.Forms.RadioButton();
            this.radio8 = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Satır
            // 
            this.Satır.DisplayMember = "2";
            this.Satır.FormattingEnabled = true;
            this.Satır.Location = new System.Drawing.Point(50, 26);
            this.Satır.Name = "Satır";
            this.Satır.Size = new System.Drawing.Size(36, 21);
            this.Satır.TabIndex = 0;
            this.Satır.SelectedIndexChanged += new System.EventHandler(this.Satır_SelectedIndexChanged);
            // 
            // Sutun
            // 
            this.Sutun.FormattingEnabled = true;
            this.Sutun.Location = new System.Drawing.Point(135, 26);
            this.Sutun.Name = "Sutun";
            this.Sutun.Size = new System.Drawing.Size(36, 21);
            this.Sutun.TabIndex = 1;
            this.Sutun.SelectedIndexChanged += new System.EventHandler(this.Sutun_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Satır";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sütun";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(275, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sütun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(185, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Satır";
            // 
            // Sutun2
            // 
            this.Sutun2.FormattingEnabled = true;
            this.Sutun2.Location = new System.Drawing.Point(321, 26);
            this.Sutun2.Name = "Sutun2";
            this.Sutun2.Size = new System.Drawing.Size(36, 21);
            this.Sutun2.TabIndex = 5;
            this.Sutun2.SelectedIndexChanged += new System.EventHandler(this.Sutun2_SelectedIndexChanged);
            // 
            // Satır2
            // 
            this.Satır2.DisplayMember = "2";
            this.Satır2.FormattingEnabled = true;
            this.Satır2.Location = new System.Drawing.Point(224, 26);
            this.Satır2.Name = "Satır2";
            this.Satır2.Size = new System.Drawing.Size(36, 21);
            this.Satır2.TabIndex = 4;
            this.Satır2.SelectedIndexChanged += new System.EventHandler(this.Satır2_SelectedIndexChanged);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio1.Location = new System.Drawing.Point(408, 25);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(69, 17);
            this.radio1.TabIndex = 8;
            this.radio1.TabStop = true;
            this.radio1.Text = "Toplama";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio4.Location = new System.Drawing.Point(539, 72);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(46, 17);
            this.radio4.TabIndex = 9;
            this.radio4.TabStop = true;
            this.radio4.Text = "CxA";
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio3.Location = new System.Drawing.Point(408, 72);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(65, 17);
            this.radio3.TabIndex = 10;
            this.radio3.TabStop = true;
            this.radio3.Text = "Çarpma";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio2.Location = new System.Drawing.Point(539, 27);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(67, 17);
            this.radio2.TabIndex = 11;
            this.radio2.TabStop = true;
            this.radio2.Text = "Çıkarma";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sonuç :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(74, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(252, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "B";
            // 
            // radio6
            // 
            this.radio6.AutoSize = true;
            this.radio6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio6.Location = new System.Drawing.Point(539, 122);
            this.radio6.Name = "radio6";
            this.radio6.Size = new System.Drawing.Size(92, 17);
            this.radio6.TabIndex = 17;
            this.radio6.TabStop = true;
            this.radio6.Text = "B\'nin Devriği";
            this.radio6.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio5.Location = new System.Drawing.Point(408, 122);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(93, 17);
            this.radio5.TabIndex = 18;
            this.radio5.TabStop = true;
            this.radio5.Text = "A\'nın Devriği";
            this.radio5.UseVisualStyleBackColor = true;
            // 
            // radio10
            // 
            this.radio10.AutoSize = true;
            this.radio10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio10.Location = new System.Drawing.Point(539, 173);
            this.radio10.Name = "radio10";
            this.radio10.Size = new System.Drawing.Size(122, 17);
            this.radio10.TabIndex = 19;
            this.radio10.TabStop = true;
            this.radio10.Text = "B\'nin determinantı";
            this.radio10.UseVisualStyleBackColor = true;
            // 
            // radio9
            // 
            this.radio9.AutoSize = true;
            this.radio9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio9.Location = new System.Drawing.Point(408, 173);
            this.radio9.Name = "radio9";
            this.radio9.Size = new System.Drawing.Size(124, 17);
            this.radio9.TabIndex = 20;
            this.radio9.TabStop = true;
            this.radio9.Text = "A\'nın Determinantı";
            this.radio9.UseVisualStyleBackColor = true;
            // 
            // Carp
            // 
            this.Carp.Location = new System.Drawing.Point(77, 205);
            this.Carp.Name = "Carp";
            this.Carp.Size = new System.Drawing.Size(25, 20);
            this.Carp.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(43, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "C :";
            // 
            // radio7
            // 
            this.radio7.AutoSize = true;
            this.radio7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio7.Location = new System.Drawing.Point(408, 221);
            this.radio7.Name = "radio7";
            this.radio7.Size = new System.Drawing.Size(79, 17);
            this.radio7.TabIndex = 24;
            this.radio7.TabStop = true;
            this.radio7.Text = "A\'nın Tersi";
            this.radio7.UseVisualStyleBackColor = true;
            // 
            // radio8
            // 
            this.radio8.AutoSize = true;
            this.radio8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio8.Location = new System.Drawing.Point(539, 221);
            this.radio8.Name = "radio8";
            this.radio8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radio8.Size = new System.Drawing.Size(78, 17);
            this.radio8.TabIndex = 25;
            this.radio8.TabStop = true;
            this.radio8.Text = "B\'nin Tersi";
            this.radio8.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(405, 341);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(219, 17);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "İntegral Ve Türev Hesaplama";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 385);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.radio8);
            this.Controls.Add(this.radio7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Carp);
            this.Controls.Add(this.radio9);
            this.Controls.Add(this.radio10);
            this.Controls.Add(this.radio5);
            this.Controls.Add(this.radio6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sutun2);
            this.Controls.Add(this.Satır2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sutun);
            this.Controls.Add(this.Satır);
            this.Name = "Form1";
            this.Text = "Matris Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Satır;
        private System.Windows.Forms.ComboBox Sutun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Sutun2;
        private System.Windows.Forms.ComboBox Satır2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radio6;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton radio10;
        private System.Windows.Forms.RadioButton radio9;
        private System.Windows.Forms.TextBox Carp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radio7;
        private System.Windows.Forms.RadioButton radio8;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

