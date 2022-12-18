using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library
{
    public partial class SabteZirGrouh : Form
    {
        public SabteZirGrouh()
        {
            InitializeComponent();
        }
        string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bank.mdb";
        public bool Add_Edit = true;
        private void SabteZirGrouh_Load(object sender, EventArgs e)
        {
            string a = "1";
            string str;
            if (Add_Edit == true)
            {

                OleDbConnection ocn1 = new OleDbConnection(ConnectionString);
                OleDbCommand sqlCmd = new OleDbCommand("SELECT COUNT(*) FROM rg", ocn1);
                ocn1.Open();
                str = Convert.ToString((int)sqlCmd.ExecuteScalar());
                int b = Int32.Parse(str) + Int32.Parse(a);
                txtID.Text = b.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            try
            {
                if (Add_Edit == true)
                {
                    OleDbConnection ocn = new OleDbConnection(ConnectionString);
                    OleDbCommand ocm = new OleDbCommand();
                    ocm.CommandText = "INSERT INTO rg (ID,Title,Comment,uptitle) VALUES (@p1,@p2,@p3,@p4)";
                    ocm.Parameters.Clear();
                    ocm.Parameters.AddWithValue("@p1", txtID.Text);
                    ocm.Parameters.AddWithValue("@p2",txtTitle.Text);
                    ocm.Parameters.AddWithValue("@p3",txtDescription.Text);
                    ocm.Parameters.AddWithValue("@p4", textBox1.Text);
                    ocm.Connection = ocn;
                    ocn.Open();
                    ocm.ExecuteNonQuery();
                    ocn.Close();
                    ocn.Dispose();
                    MessageBox.Show("زیرگروه مورد نظر با موفقیت ثبت شد", "ثبت زیرگروه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    Close();
                }
                else
                {
                    OleDbConnection ocn = new OleDbConnection(ConnectionString);
                    OleDbCommand ocm = new OleDbCommand();
                    ocm.CommandText = "UPDATE rg Set Title=? , Comment=? , uptitle=?  Where ID=?";
                    ocm.Parameters.Clear();
                    ocm.Parameters.AddWithValue("@p4", textBox1.Text);
                    ocm.Parameters.AddWithValue("@p3", txtTitle.Text);
                    ocm.Parameters.AddWithValue("@p2", txtDescription.Text);
                    ocm.Parameters.AddWithValue("@p1", txtID.Text);
                    ocm.Connection = null;
                    ocm.Connection = ocn;
                    ocn.Open();
                    ocm.ExecuteNonQuery();
                    ocn.Close();
                    ocm.Dispose();
                    ocn.Dispose();
                    MessageBox.Show("زیرگروه مورد نظر با موفقیت ویرایش شد", "ویرایش زیرگروه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("کاربر گرامی شماره ثبت تکراری است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
