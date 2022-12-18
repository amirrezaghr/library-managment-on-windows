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
    public partial class ListZirGrouh : Form
    {
        public ListZirGrouh()
        {
            InitializeComponent();
        }
        string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bank.mdb";
        string AID = "";
        string ATitle = "";
        string AComment = "";
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
                OleDbCommand sqlCmd = new OleDbCommand("SELECT COUNT(*) FROM rg", ocn);
                ocn.Open();
                lblCount.Text = "تعداد زیر گروه ها : " + Convert.ToString((int)sqlCmd.ExecuteScalar()) + "";
                ocn.Close();
                DGW1.Columns.Clear();
                DGW1.DataSource = null;
                DGW1.DataSource = dt;
                DGW1.Columns[0].Name = "DID";
                DGW1.Columns[1].Name = "DTitle";
                DGW1.Columns[2].Name = "DComment";
                DGW1.Columns[3].Name = "Duptitle";
                DGW1.Columns[0].Width = 82;
                DGW1.Columns[1].Width = 130;
                DGW1.Columns[2].Width = 130;
                DGW1.Columns[3].Width = 130;
                DGW1.Columns[0].HeaderText = "شماره ثبت";
                DGW1.Columns[1].HeaderText = "نام زیر گروه";
                DGW1.Columns[2].HeaderText = "شرح";
                DGW1.Columns[3].HeaderText = "عنوان مادر";
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
        private void ListZirGrouh_Load(object sender, EventArgs e)
        {
            Ado1("select * from rg");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("آیا مایلید مورد انتخاب شده حذف شود؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                try
                {
                    AID = DGW1.CurrentRow.Cells["DID"].Value.ToString();
                    ATitle = DGW1.CurrentRow.Cells["DTitle"].Value.ToString();
                    AComment = DGW1.CurrentRow.Cells["DComment"].Value.ToString();
                    OleDbConnection ocn = new OleDbConnection(ConnectionString);
                    OleDbCommand ocm = new OleDbCommand();
                    ocm.CommandText = "DELETE FROM rg WHERE ID=@p1 AND Title=@p2 AND Comment=@p3";
                    ocm.Parameters.Clear();
                    ocm.Parameters.AddWithValue("@p1", AID);
                    ocm.Parameters.AddWithValue("@p2", ATitle);
                    ocm.Parameters.AddWithValue("@p3", AComment);
                    ocm.Connection = null;
                    ocm.Connection = ocn;
                    ocn.Open();
                    ocm.ExecuteNonQuery();
                    ocn.Close();
                    ocm.Dispose();
                    ocn.Dispose();

                    Ado1("SELECT * FROM rg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message
                        + "\r\n\r\n"
                        + "عملایت حذف با مشکل مواجه شده است", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AID = DGW1.CurrentRow.Cells["DID"].Value.ToString();
            ATitle = DGW1.CurrentRow.Cells["DTitle"].Value.ToString();
            AComment = DGW1.CurrentRow.Cells["DComment"].Value.ToString();
            SabteZirGrouh ShowEditZirGrouh = new SabteZirGrouh();
            ShowEditZirGrouh.txtID.Text = AID;
            ShowEditZirGrouh.txtTitle.Text = ATitle;
            ShowEditZirGrouh.txtDescription.Text = AComment;
            ShowEditZirGrouh.Add_Edit = false;
            ShowEditZirGrouh.ShowDialog();
        }

    }
}
