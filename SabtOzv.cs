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
    public partial class SabtOzv : Form
    {
        public SabtOzv()
        {
            InitializeComponent();
        }
        string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bank.mdb";
        public bool Add_Edit = true;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SabtOzv_Load(object sender, EventArgs e)
        {
            string a = "1";
            string str;
            if (Add_Edit == true)
            {

                OleDbConnection ocn1 = new OleDbConnection(ConnectionString);
                OleDbCommand sqlCmd = new OleDbCommand("SELECT COUNT(*) FROM OZV", ocn1);
                ocn1.Open();
                str = Convert.ToString((int)sqlCmd.ExecuteScalar());
                int b = Int32.Parse(str) + Int32.Parse(a);
                txtID.Text = b.ToString();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if(Add_Edit==true)
                {
                    OleDbConnection ocn = new OleDbConnection(ConnectionString);
                    OleDbCommand ocm = new OleDbCommand();
                    ocm.CommandText = "INSERT INTO OZV (ID,LName,NAmeFather,Mobile,Address,PeesonalCode) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)";
                    ocm.Parameters.Clear();
                    ocm.Parameters.AddWithValue("@p1", txtID.Text);
                    ocm.Parameters.AddWithValue("@p2", txtLName.Text);
                    ocm.Parameters.AddWithValue("@p3", txtFather.Text);
                    ocm.Parameters.AddWithValue("@p4", txtMobile.Text);
                    ocm.Parameters.AddWithValue("@p5", txtAddress.Text);
                    ocm.Parameters.AddWithValue("@p6", textBox1.Text);
                    ocm.Connection = ocn;
                    ocn.Open();
                    ocm.ExecuteNonQuery();
                    ocn.Close();
                    ocn.Dispose();
                    MessageBox.Show("عضو مورد نظر با موفقیت ثبت شد", "ثبت عضو", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    Close();
                }
                else
                {
                    OleDbConnection ocn = new OleDbConnection(ConnectionString);
                    OleDbCommand ocm = new OleDbCommand();
                    ocm.CommandText = "UPDATE OZV Set LName=? , NAmeFather=? , Mobile=? , Address=? , PersonalCode=? Where ID=?";
                    ocm.Parameters.Clear();
                    ocm.Parameters.AddWithValue("@p6", textBox1.Text);
                    ocm.Parameters.AddWithValue("@p5", txtLName.Text);
                    ocm.Parameters.AddWithValue("@p4", txtFather.Text);
                    ocm.Parameters.AddWithValue("@p3", txtMobile.Text);
                    ocm.Parameters.AddWithValue("@p2", txtAddress.Text);
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
    }
}
