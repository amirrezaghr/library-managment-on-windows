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
    public partial class SabtKetab : Form
    {
        public SabtKetab()
        {
            InitializeComponent();
        }
        string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bank.mdb";
        public bool Add_Edit = true;
        private void SabtKetab_Load(object sender, EventArgs e)
        {
            string a = "1";
            string str;
            if (Add_Edit == true)
            {

                OleDbConnection ocn1 = new OleDbConnection(ConnectionString);
                OleDbCommand sqlCmd = new OleDbCommand("SELECT COUNT(*) FROM Books", ocn1);
                OleDbCommand cm1 = new OleDbCommand("SELECT * FROM rg", ocn1);
                OleDbDataAdapter da = new OleDbDataAdapter(cm1);
                DataSet ds = new DataSet();
                ocn1.Open();
                da.Fill(ds, "rg");
                comboGroups.DataSource = ds;
                comboGroups.DisplayMember = "rg.Title";
                comboBox1.DataSource = ds;
                comboBox1.DisplayMember = "rg.uptitle";

                str = Convert.ToString((int)sqlCmd.ExecuteScalar());
                int b = Int32.Parse(str) + Int32.Parse(a);
                txtID.Text = b.ToString();
            }
            else
            {
                OleDbConnection ocn1 = new OleDbConnection(ConnectionString);
                OleDbCommand cm1 = new OleDbCommand("SELECT * FROM rg", ocn1);
                OleDbDataAdapter da = new OleDbDataAdapter(cm1);
                DataSet ds = new DataSet();
                ocn1.Open();
                da.Fill(ds, "rg");
                comboGroups.DataSource = ds;
                comboGroups.DisplayMember = "rg.Title";
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (Add_Edit == true)
                {
                    OleDbConnection ocn = new OleDbConnection(ConnectionString);
                    OleDbCommand ocm = new OleDbCommand();
                    ocm.CommandText = "INSERT INTO Books (ID,CodeBook,Namebook,ZirGrouh,Price,author,comment,Ozirgrouh) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                    ocm.Parameters.Clear();
                    ocm.Parameters.AddWithValue("@p1", txtID.Text);
                    ocm.Parameters.AddWithValue("@p2", txtCodebook.Text);
                    ocm.Parameters.AddWithValue("@p3",txtNameBook.Text);
                    ocm.Parameters.AddWithValue("@p4", comboGroups.Text);
                    ocm.Parameters.AddWithValue("@p5", txtPrice.Text);
                    ocm.Parameters.AddWithValue("@p6",txtAuthor.Text);
                    ocm.Parameters.AddWithValue("@p7", txtComments.Text);
                    ocm.Parameters.AddWithValue("@p8", comboBox1.Text);
                    ocm.Connection = ocn;
                    ocn.Open();
                    ocm.ExecuteNonQuery();
                    ocn.Close();
                    ocn.Dispose();
                    MessageBox.Show("کتاب مورد نظر با موفقیت ثبت شد", "ثبت کتاب", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    Close();
                }
                else
                {
                    OleDbConnection ocn = new OleDbConnection(ConnectionString);
                    OleDbCommand ocm = new OleDbCommand();
                    ocm.CommandText = "UPDATE Books Set CodeBook=? , Namebook=? , ZirGrouh=? , Price=? , author=? , comment=? , Ozirgrouh=?  Where ID=?";
                    ocm.Parameters.Clear();
                    ocm.Parameters.AddWithValue("@p8", comboBox1.Text);
                    ocm.Parameters.AddWithValue("@p7", txtCodebook.Text);
                    ocm.Parameters.AddWithValue("@p6", txtNameBook.Text);
                    ocm.Parameters.AddWithValue("@p5", comboGroups.Text);
                    ocm.Parameters.AddWithValue("@p4", txtPrice.Text);
                    ocm.Parameters.AddWithValue("@p3", txtAuthor.Text);
                    ocm.Parameters.AddWithValue("@p2", txtComments.Text);
                    ocm.Parameters.AddWithValue("@p1", txtID.Text);
                    ocm.Connection = null;
                    ocm.Connection = ocn;
                    ocn.Open();
                    ocm.ExecuteNonQuery();
                    ocn.Close();
                    ocm.Dispose();
                    ocn.Dispose();
                    MessageBox.Show("کتاب مورد نظر با موفقیت ویرایش شد", "ویرایش کتاب", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("کاربر گرامی شماره ثبت تکراری است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
