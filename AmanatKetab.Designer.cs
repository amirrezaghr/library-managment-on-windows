namespace Library
{
    partial class AmanatKetab
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.comboZirGrouh = new System.Windows.Forms.ComboBox();
            this.comboKetabName = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateReturn = new System.Windows.Forms.TextBox();
            this.txtDateTahvil = new System.Windows.Forms.TextBox();
            this.txtVDateReturn = new System.Windows.Forms.TextBox();
            this.txtVaz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "انتخاب زیرگروه:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام تحویل گیرنده:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 93);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "نام کتاب:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 120);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "تاریخ تحویل:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 147);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "تاریخ بازگشت:";
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(100, 36);
            this.comboName.Name = "comboName";
            this.comboName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboName.Size = new System.Drawing.Size(271, 25);
            this.comboName.TabIndex = 11;
            // 
            // comboZirGrouh
            // 
            this.comboZirGrouh.FormattingEnabled = true;
            this.comboZirGrouh.Location = new System.Drawing.Point(100, 63);
            this.comboZirGrouh.Name = "comboZirGrouh";
            this.comboZirGrouh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboZirGrouh.Size = new System.Drawing.Size(271, 25);
            this.comboZirGrouh.TabIndex = 12;
            // 
            // comboKetabName
            // 
            this.comboKetabName.FormattingEnabled = true;
            this.comboKetabName.Location = new System.Drawing.Point(100, 90);
            this.comboKetabName.Name = "comboKetabName";
            this.comboKetabName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboKetabName.Size = new System.Drawing.Size(271, 25);
            this.comboKetabName.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(300, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "انصراف";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Location = new System.Drawing.Point(100, 212);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "ثبت اطلاعات";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 8);
            this.txtID.Name = "txtID";
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtID.Size = new System.Drawing.Size(271, 24);
            this.txtID.TabIndex = 17;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 11);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "شماره ثبت :";
            // 
            // txtDateReturn
            // 
            this.txtDateReturn.Location = new System.Drawing.Point(100, 144);
            this.txtDateReturn.Name = "txtDateReturn";
            this.txtDateReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateReturn.Size = new System.Drawing.Size(271, 24);
            this.txtDateReturn.TabIndex = 6;
            this.txtDateReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateTahvil
            // 
            this.txtDateTahvil.Location = new System.Drawing.Point(100, 117);
            this.txtDateTahvil.Name = "txtDateTahvil";
            this.txtDateTahvil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateTahvil.Size = new System.Drawing.Size(271, 24);
            this.txtDateTahvil.TabIndex = 10;
            this.txtDateTahvil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVDateReturn
            // 
            this.txtVDateReturn.Location = new System.Drawing.Point(100, 339);
            this.txtVDateReturn.Name = "txtVDateReturn";
            this.txtVDateReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVDateReturn.Size = new System.Drawing.Size(271, 24);
            this.txtVDateReturn.TabIndex = 18;
            this.txtVDateReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVaz
            // 
            this.txtVaz.Location = new System.Drawing.Point(100, 366);
            this.txtVaz.Name = "txtVaz";
            this.txtVaz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVaz.Size = new System.Drawing.Size(271, 24);
            this.txtVaz.TabIndex = 19;
            this.txtVaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 369);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "وضعیت :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 177);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "نسبت:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(271, 24);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AmanatKetab
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(383, 250);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVaz);
            this.Controls.Add(this.txtVDateReturn);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.comboKetabName);
            this.Controls.Add(this.comboZirGrouh);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.txtDateTahvil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AmanatKetab";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "امانت کتاب";
            this.Load += new System.EventHandler(this.AmanatKetab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnApply;
        public System.Windows.Forms.ComboBox comboName;
        public System.Windows.Forms.ComboBox comboZirGrouh;
        public System.Windows.Forms.ComboBox comboKetabName;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtDateReturn;
        public System.Windows.Forms.TextBox txtDateTahvil;
        public System.Windows.Forms.TextBox txtVDateReturn;
        public System.Windows.Forms.TextBox txtVaz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox1;
    }
}