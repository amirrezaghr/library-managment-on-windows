using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddGroupBooks_Click(object sender, EventArgs e)
        {
            SabteZirGrouh ShowAddGroups = new SabteZirGrouh();
            ShowAddGroups.ShowDialog();
        }

        private void ListGroupBooks_Click(object sender, EventArgs e)
        {
            ListZirGrouh ShowListGroups = new ListZirGrouh();
            ShowListGroups.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آیا میخواهید خارج شوید؟", "خروج",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            SabtKetab ShowAddBooks = new SabtKetab();
            ShowAddBooks.ShowDialog();
        }

        private void ListBooks_Click(object sender, EventArgs e)
        {
            ListKetab ShowListBooks = new ListKetab();
            ShowListBooks.ShowDialog();
        }

        private void AddMembers_Click(object sender, EventArgs e)
        {
            SabtOzv ShowAddMemebers = new SabtOzv();
            ShowAddMemebers.ShowDialog();
        }

        private void ListMembers_Click(object sender, EventArgs e)
        {
            ListOzv ShowListMembers = new ListOzv();
            ShowListMembers.ShowDialog();
        }

        private void About_Click(object sender, EventArgs e)
        {
            frmAbout ShowfrmAbout = new frmAbout();
            ShowfrmAbout.ShowDialog();
        }

        private void AddAmanats_Click(object sender, EventArgs e)
        {
            AmanatKetab ShowAmanatbook = new AmanatKetab();
            ShowAmanatbook.ShowDialog();
        }

        private void ListAmanat_Click(object sender, EventArgs e)
        {
            frmListAmanat ShowAmanats = new frmListAmanat();
            ShowAmanats.ShowDialog();
        }

        private void backbooks_Click(object sender, EventArgs e)
        {
            frmBargashtKetab ShowBargashBook = new frmBargashtKetab();
            ShowBargashBook.ShowDialog();
        }

        private void Backup_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.Books |*.Books";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName != "")
                {
                    try
                    {
                        if (File.Exists(sfd.FileName) == true)
                            File.Delete(sfd.FileName);
                        File.Copy(Application.StartupPath + "\\bank.mdb", sfd.FileName);
                        MessageBox.Show("پشتیبان گیری با موفقیت انجام شد", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.Books |*.Books";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != "")
                {

                    if (MessageBox.Show("آیا میخواهید فایل پشتیبان، جایگزین بانک فعلی برنامه شود؟؟؟(!!! توجه: بانک فعلی کامل از بین میرود !!!)؟؟؟", "سوال خیلی مهم؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(Application.StartupPath + "\\bank.mdb");
                        File.Copy(ofd.FileName, Application.StartupPath + "\\bank.mdb");
                        MessageBox.Show("بانک برنامه با موفقیت بازیابی شد", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\u0000';
            }
            else
            {
                textBox2.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "public" && textBox2.Text == "12345678")
            {
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمزعبور وارد شده اشتباه است ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
