namespace Library
{
    partial class frmBargashtKetab
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
            this.DGW1 = new System.Windows.Forms.DataGridView();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameOzv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGW1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGW1
            // 
            this.DGW1.AllowUserToAddRows = false;
            this.DGW1.AllowUserToDeleteRows = false;
            this.DGW1.AllowUserToOrderColumns = true;
            this.DGW1.AllowUserToResizeColumns = false;
            this.DGW1.AllowUserToResizeRows = false;
            this.DGW1.ColumnHeadersHeight = 33;
            this.DGW1.Location = new System.Drawing.Point(12, 38);
            this.DGW1.Name = "DGW1";
            this.DGW1.Size = new System.Drawing.Size(592, 292);
            this.DGW1.TabIndex = 12;
            this.DGW1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW1_CellClick);
            // 
            // txtNameBook
            // 
            this.txtNameBook.Enabled = false;
            this.txtNameBook.Location = new System.Drawing.Point(79, 338);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNameBook.Size = new System.Drawing.Size(198, 24);
            this.txtNameBook.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 341);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "نام کتاب:";
            // 
            // txtNameOzv
            // 
            this.txtNameOzv.Enabled = false;
            this.txtNameOzv.Location = new System.Drawing.Point(406, 338);
            this.txtNameOzv.Name = "txtNameOzv";
            this.txtNameOzv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNameOzv.Size = new System.Drawing.Size(198, 24);
            this.txtNameOzv.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 341);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "نام عضو:";
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Location = new System.Drawing.Point(529, 375);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "بازگشت";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Location = new System.Drawing.Point(12, 375);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(147, 23);
            this.btnApply.TabIndex = 21;
            this.btnApply.Text = "کتاب فوق برگشت داده شد";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(529, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "جستجو";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 24);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "نام تحویل گیرنده",
            "نام کتاب"});
            this.comboBox1.Location = new System.Drawing.Point(12, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 25);
            this.comboBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(364, 411);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(137, 411);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 24);
            this.textBox3.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(67, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "شماره ثبت :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(310, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "وضعیت :";
            // 
            // frmBargashtKetab
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(618, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtNameOzv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNameBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGW1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBargashtKetab";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "برگشت کتاب";
            this.Load += new System.EventHandler(this.frmBargashtKetab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW1;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameOzv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}