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
    public partial class frmBargashtKetab : Form
    {
        public frmBargashtKetab()
        {
            InitializeComponent();
        }
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
                
                ocn.Open();
                ocn.Close();
                DGW1.Columns.Clear();
                DGW1.DataSource = null;
                DGW1.DataSource = dt;
                
                DGW1.Columns[1].Name = "DNameBook";
                DGW1.Columns[3].Name = "DNameOzv";
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

                if (DGW1.Rows.Count > 0)
                {
                    btnApply.Enabled = true;
                }
                else
                {
                    btnApply.Enabled = false;
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmBargashtKetab_Load(object sender, EventArgs e)
        {
            Ado1("Select * from Amanat where molahezat='امانت'");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void DGW1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text =DGW1.CurrentRow.Cells[0].Value.ToString();
            txtNameBook.Text = DGW1.CurrentRow.Cells[1].Value.ToString();
            txtNameOzv.Text = DGW1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = DGW1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            textBox2.Text = "تحویل داده شده";
            try
            {
                OleDbConnection ocn = new OleDbConnection(ConnectionString);
                OleDbCommand ocm = new OleDbCommand();
                ocm.CommandText = "UPDATE Amanat Set molahezat=? Where ID=?";
                ocm.Parameters.Clear();
                ocm.Parameters.AddWithValue("@p2", textBox2.Text);
                ocm.Parameters.AddWithValue("@p1", textBox3.Text);
                ocm.Connection = null;
                ocm.Connection = ocn;
                ocn.Open();
                ocm.ExecuteNonQuery();
                ocn.Close();
                ocm.Dispose();
                ocn.Dispose();
                Ado1("Select * from Amanat where molahezat='امانت'");
                MessageBox.Show("کتاب مورد نظر با موفقیت تحویل داده شد", "تحویل کتاب", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
            catch
            {
                
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
