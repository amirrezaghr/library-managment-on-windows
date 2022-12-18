using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Library
{
    public partial class ListKetab : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        public ListKetab()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
        }


        string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bank.mdb";
        string BID = "";
        string BCodeBook = "";
        string BNameBook = "";
        string BZirGrouh = "";
        string BPrice = "";
        string BAuthor = "";
        string BComment = "";
        private string connectionString;

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
                OleDbCommand sqlCmd = new OleDbCommand("SELECT COUNT(*) FROM books", ocn);
                ocn.Open();
                lblCount.Text = "تعداد کتاب ها : " + Convert.ToString((int)sqlCmd.ExecuteScalar()) + "";
                ocn.Close();
                DGW1.Columns.Clear();
                DGW1.DataSource = null;
                DGW1.DataSource = dt;
                DGW1.Columns[0].Name = "DID";
                DGW1.Columns[1].Name = "DCodeBook";
                DGW1.Columns[2].Name = "DNameBook";
                DGW1.Columns[3].Name = "DZirGrouh";
                DGW1.Columns[4].Name = "DPrice";
                DGW1.Columns[5].Name = "DAuthor";
                DGW1.Columns[6].Name = "DComment";
                DGW1.Columns[0].Width = 82;
                DGW1.Columns[6].Width = 300;
                DGW1.Columns[0].HeaderText = "شماره ثبت";
                DGW1.Columns[1].HeaderText = "کد کتاب";
                DGW1.Columns[2].HeaderText = "نام کتاب";
                DGW1.Columns[3].HeaderText = "موضوع";
                DGW1.Columns[4].HeaderText = "قیمت";
                DGW1.Columns[5].HeaderText = "نویسنده";
                DGW1.Columns[6].HeaderText = "توضیحات";

                dt.Dispose();
                oda.Dispose();
                ocn.Dispose();
                if (DGW1.Rows.Count > 0)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListKetab_Load(object sender, EventArgs e)
        {
            Ado1("select * from books");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (comboSelect.SelectedIndex)
            { 
                case 0:
                    Ado1("SELECT * FROM Books WHERE NameBook LIKE '" + txtSearch.Text + "%'");
                    break;
                case 1:
                    Ado1("SELECT * FROM Books WHERE ZirGrouh LIKE '" + txtSearch.Text + "%'");
                    break;
                case 2:
                    Ado1("SELECT * FROM Books WHERE Author LIKE '" + txtSearch.Text + "%'");
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BID = DGW1.CurrentRow.Cells["DID"].Value.ToString();
            BCodeBook = DGW1.CurrentRow.Cells["DCodeBook"].Value.ToString();
            BNameBook = DGW1.CurrentRow.Cells["DNameBook"].Value.ToString();
            BZirGrouh = DGW1.CurrentRow.Cells["DZirGrouh"].Value.ToString();
            BPrice = DGW1.CurrentRow.Cells["DPrice"].Value.ToString();
            BAuthor = DGW1.CurrentRow.Cells["DAuthor"].Value.ToString();
            BComment = DGW1.CurrentRow.Cells["DComment"].Value.ToString();
            SabtKetab ShowEditKatab = new SabtKetab();
            ShowEditKatab.txtID.Text= BID;
            ShowEditKatab.txtCodebook.Text = BCodeBook;
            ShowEditKatab.txtNameBook.Text = BNameBook;
            ShowEditKatab.comboGroups.Text = BZirGrouh;
            ShowEditKatab.txtPrice.Text = BPrice;
            ShowEditKatab.txtAuthor.Text = BAuthor;
            ShowEditKatab.txtComments.Text = BComment;
            ShowEditKatab.Add_Edit = false;
            ShowEditKatab.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("آیا مایلید مورد انتخاب شده حذف شود؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                try
                {
                    BID = DGW1.CurrentRow.Cells["DID"].Value.ToString();
                    BCodeBook = DGW1.CurrentRow.Cells["DCodeBook"].Value.ToString();
                    BNameBook = DGW1.CurrentRow.Cells["DNameBook"].Value.ToString();
                    BZirGrouh = DGW1.CurrentRow.Cells["DZirGrouh"].Value.ToString();
                    BPrice = DGW1.CurrentRow.Cells["DPrice"].Value.ToString();
                    BAuthor = DGW1.CurrentRow.Cells["DAuthor"].Value.ToString();
                    BComment = DGW1.CurrentRow.Cells["DComment"].Value.ToString();

                    OleDbConnection ocn = new OleDbConnection(ConnectionString);
                    OleDbCommand ocm = new OleDbCommand();
                    ocm.CommandText = "DELETE FROM Books WHERE ID=@p1 AND CodeBook=@p2 AND NameBook=@p3 AND ZirGrouh=@p4 AND Price=@p5 AND Author=@p6 AND Comment=@p7";
                    ocm.Parameters.Clear();
                    ocm.Parameters.AddWithValue("@p1", BID);
                    ocm.Parameters.AddWithValue("@p2", BCodeBook);
                    ocm.Parameters.AddWithValue("@p3", BNameBook);
                    ocm.Parameters.AddWithValue("@p4", BZirGrouh);
                    ocm.Parameters.AddWithValue("@p5", BPrice);
                    ocm.Parameters.AddWithValue("@p6", BAuthor);
                    ocm.Parameters.AddWithValue("@p7", BComment);
                    ocm.Connection = null;
                    ocm.Connection = ocn;
                    ocn.Open();
                    ocm.ExecuteNonQuery();
                    ocn.Close();
                    ocm.Dispose();
                    ocn.Dispose();
                    Ado1("SELECT * FROM Books");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message
                        + "\r\n\r\n"
                        + "عملایت حذف با مشکل مواجه شده است", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }

            //string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bank.mdb";
            ////string connectionString = "Data Source=.;Initial Catalog=pubs;Integrated Security=True";
            //string sql = "SELECT * FROM Authors";
            //SqlConnection connection = new SqlConnection(connectionString);
            //SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            //DataSet ds = new DataSet();
            //connection.Open();
            //dataadapter.Fill(ds, "Author_table");
            //connection.Close();
            //DGW1.DataSource = ds;
            //DGW1.DataMember = "Author_table";

            //printDocument1.Print();

            //Bitmap bm = new Bitmap(this.DGW1.Width, this.DGW1.Height);
            //DGW1.DrawToBitmap(bm, new Rectangle(0, 0, this.DGW1.Width, this.DGW1.Height));





        }
    }
}
