namespace Library
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.کتابهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Groupsbooks = new System.Windows.Forms.ToolStripMenuItem();
            this.AddGroupBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ListGroupBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.اعضاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.Amanats = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAmanats = new System.Windows.Forms.ToolStripMenuItem();
            this.ListAmanat = new System.Windows.Forms.ToolStripMenuItem();
            this.backbooks = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.backupsoft = new System.Windows.Forms.ToolStripMenuItem();
            this.Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کتابهاToolStripMenuItem,
            this.اعضاToolStripMenuItem,
            this.Amanats,
            this.Tools,
            this.About,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1136, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // کتابهاToolStripMenuItem
            // 
            this.کتابهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Groupsbooks,
            this.toolStripSeparator2,
            this.AddBooks,
            this.ListBooks});
            this.کتابهاToolStripMenuItem.Image = global::Library.Properties.Resources.Books;
            this.کتابهاToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.کتابهاToolStripMenuItem.Name = "کتابهاToolStripMenuItem";
            this.کتابهاToolStripMenuItem.Size = new System.Drawing.Size(97, 37);
            this.کتابهاToolStripMenuItem.Text = "کتاب ها";
            // 
            // Groupsbooks
            // 
            this.Groupsbooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddGroupBooks,
            this.toolStripSeparator1,
            this.ListGroupBooks});
            this.Groupsbooks.Name = "Groupsbooks";
            this.Groupsbooks.Size = new System.Drawing.Size(168, 26);
            this.Groupsbooks.Text = "زیر گروه کتاب ";
            // 
            // AddGroupBooks
            // 
            this.AddGroupBooks.Name = "AddGroupBooks";
            this.AddGroupBooks.Size = new System.Drawing.Size(260, 26);
            this.AddGroupBooks.Text = "ثبت زیر گروه جدید";
            this.AddGroupBooks.Click += new System.EventHandler(this.AddGroupBooks_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // ListGroupBooks
            // 
            this.ListGroupBooks.Name = "ListGroupBooks";
            this.ListGroupBooks.Size = new System.Drawing.Size(260, 26);
            this.ListGroupBooks.Text = "لیست زیر گروه های ثبت شده ";
            this.ListGroupBooks.Click += new System.EventHandler(this.ListGroupBooks_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // AddBooks
            // 
            this.AddBooks.Name = "AddBooks";
            this.AddBooks.Size = new System.Drawing.Size(168, 26);
            this.AddBooks.Text = "ثبت کتاب جدید";
            this.AddBooks.Click += new System.EventHandler(this.AddBooks_Click);
            // 
            // ListBooks
            // 
            this.ListBooks.Name = "ListBooks";
            this.ListBooks.Size = new System.Drawing.Size(168, 26);
            this.ListBooks.Text = "لیست کتاب ها";
            this.ListBooks.Click += new System.EventHandler(this.ListBooks_Click);
            // 
            // اعضاToolStripMenuItem
            // 
            this.اعضاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMembers,
            this.ListMembers});
            this.اعضاToolStripMenuItem.Image = global::Library.Properties.Resources.users;
            this.اعضاToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.اعضاToolStripMenuItem.Name = "اعضاToolStripMenuItem";
            this.اعضاToolStripMenuItem.Size = new System.Drawing.Size(98, 37);
            this.اعضاToolStripMenuItem.Text = "اعضا   ";
            // 
            // AddMembers
            // 
            this.AddMembers.Name = "AddMembers";
            this.AddMembers.Size = new System.Drawing.Size(166, 26);
            this.AddMembers.Text = "ثبت عضو جدید";
            this.AddMembers.Click += new System.EventHandler(this.AddMembers_Click);
            // 
            // ListMembers
            // 
            this.ListMembers.Name = "ListMembers";
            this.ListMembers.Size = new System.Drawing.Size(166, 26);
            this.ListMembers.Text = "لیست عضو ها";
            this.ListMembers.Click += new System.EventHandler(this.ListMembers_Click);
            // 
            // Amanats
            // 
            this.Amanats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAmanats,
            this.ListAmanat,
            this.backbooks});
            this.Amanats.Image = global::Library.Properties.Resources.appointment_new;
            this.Amanats.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Amanats.Name = "Amanats";
            this.Amanats.Size = new System.Drawing.Size(98, 37);
            this.Amanats.Text = "امانت ها";
            // 
            // AddAmanats
            // 
            this.AddAmanats.Name = "AddAmanats";
            this.AddAmanats.Size = new System.Drawing.Size(175, 26);
            this.AddAmanats.Text = "امانت جدید";
            this.AddAmanats.Click += new System.EventHandler(this.AddAmanats_Click);
            // 
            // ListAmanat
            // 
            this.ListAmanat.Name = "ListAmanat";
            this.ListAmanat.Size = new System.Drawing.Size(175, 26);
            this.ListAmanat.Text = "لیست امانت ها ";
            this.ListAmanat.Click += new System.EventHandler(this.ListAmanat_Click);
            // 
            // backbooks
            // 
            this.backbooks.Name = "backbooks";
            this.backbooks.Size = new System.Drawing.Size(175, 26);
            this.backbooks.Text = "برگشت کتاب";
            this.backbooks.Click += new System.EventHandler(this.backbooks_Click);
            // 
            // Tools
            // 
            this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupsoft});
            this.Tools.Image = global::Library.Properties.Resources.settings;
            this.Tools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(87, 37);
            this.Tools.Text = "امکانات";
            // 
            // backupsoft
            // 
            this.backupsoft.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Backup,
            this.toolStripSeparator3,
            this.Restore});
            this.backupsoft.Name = "backupsoft";
            this.backupsoft.Size = new System.Drawing.Size(163, 26);
            this.backupsoft.Text = "پشتیبان گیری";
            // 
            // Backup
            // 
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(172, 26);
            this.Backup.Text = "پشتیبانی گیری";
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // Restore
            // 
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(172, 26);
            this.Restore.Text = "بازیابی پشتیبان";
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // About
            // 
            this.About.Image = global::Library.Properties.Resources.help;
            this.About.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(94, 37);
            this.About.Text = "درباره ما";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Exit
            // 
            this.Exit.Image = global::Library.Properties.Resources.Power;
            this.Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(78, 37);
            this.Exit.Text = "خروج";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 619);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library.Properties.Resources.Lib;
            this.pictureBox2.Location = new System.Drawing.Point(611, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.naft_2;
            this.pictureBox1.Location = new System.Drawing.Point(227, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(147, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 353);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود کاربر";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new System.Drawing.Size(388, 22);
            this.textBox2.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(53, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "نمایش رمز عبور";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(465, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "ورود";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(208, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "رمز عبور :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام کاربری :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1136, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار مدیریت کتابخانه روابط عمومی منطقه شمال";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem کتابهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Groupsbooks;
        private System.Windows.Forms.ToolStripMenuItem AddGroupBooks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ListGroupBooks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem AddBooks;
        private System.Windows.Forms.ToolStripMenuItem ListBooks;
        private System.Windows.Forms.ToolStripMenuItem اعضاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMembers;
        private System.Windows.Forms.ToolStripMenuItem ListMembers;
        private System.Windows.Forms.ToolStripMenuItem Amanats;
        private System.Windows.Forms.ToolStripMenuItem AddAmanats;
        private System.Windows.Forms.ToolStripMenuItem ListAmanat;
        private System.Windows.Forms.ToolStripMenuItem backbooks;
        private System.Windows.Forms.ToolStripMenuItem Tools;
        private System.Windows.Forms.ToolStripMenuItem backupsoft;
        private System.Windows.Forms.ToolStripMenuItem Backup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Restore;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

