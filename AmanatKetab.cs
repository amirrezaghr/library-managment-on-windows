using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Library
{
    public partial class AmanatKetab : Form
    {
        public AmanatKetab()
        {
            InitializeComponent();
        }
        
        string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bank.mdb";
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AmanatKetab_Load(object sender, EventArgs e)
        {
            string a = "1";
            string str;

            try
            {
                OleDbConnection ocn1 = new OleDbConnection(ConnectionString);
                OleDbCommand sqlCmd = new OleDbCommand("SELECT COUNT(*) FROM Amanat", ocn1);
                OleDbCommand cm1 = new OleDbCommand("SELECT * FROM ozv", ocn1);
                OleDbCommand cm2 = new OleDbCommand("SELECT * FROM books", ocn1);
                OleDbCommand cm3 = new OleDbCommand("SELECT * FROM rg", ocn1);
                OleDbDataAdapter da1 = new OleDbDataAdapter(cm1);
                OleDbDataAdapter da2 = new OleDbDataAdapter(cm2);
                OleDbDataAdapter da3 = new OleDbDataAdapter(cm3);

                DataSet ds1 = new DataSet();
                DataSet ds2 = new DataSet();
                DataSet ds3 = new DataSet();

                ocn1.Open();

                da1.Fill(ds1, "OZV");
                comboName.DataSource = ds1;
                comboName.DisplayMember = "OZV.Lname";

                da2.Fill(ds2, "Books");
                comboKetabName.DataSource = ds2;
                comboKetabName.DisplayMember = "Books.NameBook";

                da3.Fill(ds3, "rg");
                comboZirGrouh.DataSource = ds3;
                comboZirGrouh.DisplayMember = "rg.Title";

                str = Convert.ToString((int)sqlCmd.ExecuteScalar());
                int b = Int32.Parse(str) + Int32.Parse(a);
                txtID.Text = b.ToString();

                PersianCalendar showdate1 = new PersianCalendar();
                txtDateTahvil.Text = showdate1.GetYear(DateTime.Now).ToString()
                    + "/" + showdate1.GetMonth(DateTime.Now).ToString()
                    + "/" + showdate1.GetDayOfMonth(DateTime.Now).ToString();
                txtVDateReturn.Text = txtDateTahvil.Text.Trim().Replace("/", "");
                comboName.Text = "";
                comboKetabName.Text = "";
                comboZirGrouh.Text = "";

            }
            catch
            { 
                
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                 txtVaz.Text = "امانت";
                OleDbConnection ocn = new OleDbConnection(ConnectionString);
                OleDbCommand ocm = new OleDbCommand();
                ocm.CommandText = "INSERT INTO Amanat (ID,LNameG,NameBook,ZirGrouh,SDateTahvil,SDateReturn,VDateReturn,molahezat,Nesbat) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
                ocm.Parameters.Clear();
                ocm.Parameters.AddWithValue("@p1", txtID.Text);
                ocm.Parameters.AddWithValue("@p2", comboName.Text);
                ocm.Parameters.AddWithValue("@p3", comboKetabName.Text);
                ocm.Parameters.AddWithValue("@p4", comboZirGrouh.Text);
                ocm.Parameters.AddWithValue("@p5", txtDateTahvil.Text);
                ocm.Parameters.AddWithValue("@p6", txtDateReturn.Text);
                ocm.Parameters.AddWithValue("@p7", txtVDateReturn.Text);
                ocm.Parameters.AddWithValue("@p8", txtVaz.Text);
                ocm.Parameters.AddWithValue("@p9", textBox1.Text);
                ocm.Connection = ocn;
                ocn.Open();
                ocm.ExecuteNonQuery();
                ocn.Close();
                ocn.Dispose();
                MessageBox.Show("کتاب مورد نظر با موفقیت ثبت شد", "ثبت کتاب", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                Close();
            }
            catch
            {
                MessageBox.Show("کاربر گرامی شماره ثبت تکراری است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
        }
    }
}
