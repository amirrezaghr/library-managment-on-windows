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
    public partial class frmListAmanat : Form
    {
        public frmListAmanat()
        {
            InitializeComponent();
        }
        public int bb;
        string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bank.mdb";
        private void Ado1(string strSqlQuery)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                OleDbConnection ocn = new OleDbConnection(ConnectionString);
                OleDbDataAdapter oda = new OleDbDataAdapter(strSqlQuery, ocn);
                DataTable dt = new DataTable();
                dt.Clear();
                oda.Fill(dt);
                OleDbCommand sqlCmd = new OleDbCommand("SELECT COUNT(*) FROM Amanat where molahezat='امانت'", ocn);
                ocn.Open();
                lblCount.Text = "تعداد کتاب های امانت داده شده : " + Convert.ToString((int)sqlCmd.ExecuteScalar()) + "";
                ocn.Close();
                DGW1.Columns.Clear();
                DGW1.DataSource = null;
                DGW1.DataSource = dt;
                DGW1.Columns[0].Width = 82;
                DGW1.Columns[2].Width = 182;
                DGW1.Columns[0].HeaderText = "شماره ثبت";
                DGW1.Columns[1].HeaderText = "نام تحویل گیرنده";
                DGW1.Columns[2].HeaderText = "گروه کتاب";
                DGW1.Columns[3].HeaderText = "نام کتاب";
                DGW1.Columns[4].HeaderText = "تاریخ تحویل";
                DGW1.Columns[5].HeaderText = "تاریخ بازگشت";
                DGW1.Columns[6].Visible = false;
                DGW1.Columns[7].HeaderText = "ملاحضات";
                dt.Dispose();
                oda.Dispose();
                ocn.Dispose();
                
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListAmanat_Load(object sender, EventArgs e)
        {
            Ado1("Select * from Amanat where molahezat='امانت'");
            PersianCalendar Date1 = new PersianCalendar();
            lblDate.Text =Date1.GetYear(DateTime.Now).ToString()
                + "/" + Date1.GetMonth(DateTime.Now).ToString()
                + "/" + Date1.GetDayOfMonth(DateTime.Now).ToString();
            string Dates = lblDate.Text.Trim().Replace("/", "");
            bb = Int32.Parse(Dates);
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDataGozashte_Click(object sender, EventArgs e)
        {
            Ado1("Select * from Amanat where VDateReturn < '" + bb +"'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ado1("Select * from Amanat where molahezat='امانت'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ado1("Select * from Amanat where molahezat='تحویل داده شده'");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Ado1("SELECT * FROM Amanat WHERE LNameG LIKE '" + textBox1.Text + "%'");
                    break;
                case 1:
                    Ado1("SELECT * FROM Amanat WHERE Namebook LIKE '" + textBox1.Text + "%'");
                    break;
            }
        }
    }
}
