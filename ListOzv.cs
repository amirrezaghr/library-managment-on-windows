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
    public partial class ListOzv : Form
    {
        public ListOzv()
        {
            InitializeComponent();
        }
        string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bank.mdb";
        string OID = "";
        string OLName = "";
        string ONameFather = "";
        string OMobile = "";
        string OAddress = "";
        string OPersonalCode = "";
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
                OleDbCommand sqlCmd = new OleDbCommand("SELECT COUNT(*) FROM OZV", ocn);
                ocn.Open();
                lblCount.Text = "تعداد عضو ها : " + Convert.ToString((int)sqlCmd.ExecuteScalar()) + "";
                ocn.Close();
                DGW1.Columns.Clear();
                DGW1.DataSource = null;
                DGW1.DataSource = dt;
                DGW1.Columns[0].Name = "DID";
                DGW1.Columns[1].Name = "DLName";
                DGW1.Columns[2].Name = "DNameFather";
                DGW1.Columns[3].Name = "DMobile";
                DGW1.Columns[4].Name = "DAddress";
                DGW1.Columns[5].Name = "DPersonalCode";

                DGW1.Columns[0].Width = 82;
                DGW1.Columns[1].Width = 130;
                DGW1.Columns[4].Width = 300;

                DGW1.Columns[0].HeaderText = "شماره ثبت";
                DGW1.Columns[1].HeaderText = "نام و نام خانوادگی";
                DGW1.Columns[2].HeaderText = "نام پدر";
                DGW1.Columns[3].HeaderText = "موبایل";
                DGW1.Columns[4].HeaderText = "آدرس";
                DGW1.Columns[5].HeaderText = "کد پرسنلی";


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
        private void ListOzv_Load(object sender, EventArgs e)
        {
            Ado1("Select * from OZV");
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
                    OID = DGW1.CurrentRow.Cells["DID"].Value.ToString();
                    OLName = DGW1.CurrentRow.Cells["DLName"].Value.ToString();
                    ONameFather = DGW1.CurrentRow.Cells["DNameFather"].Value.ToString();
                    OMobile = DGW1.CurrentRow.Cells["DMobile"].Value.ToString();
                    OAddress = DGW1.CurrentRow.Cells["DAddress"].Value.ToString();

                    OleDbConnection ocn = new OleDbConnection(ConnectionString);
                    OleDbCommand ocm = new OleDbCommand();
                    ocm.CommandText = "DELETE FROM OZV WHERE ID=@p1 AND LName=@p2 AND NameFather=@p3 AND Mobile=@p4 AND Address=@p5";
                    ocm.Parameters.Clear();
                    ocm.Parameters.AddWithValue("@p1", OID);
                    ocm.Parameters.AddWithValue("@p2", OLName);
                    ocm.Parameters.AddWithValue("@p3", ONameFather);
                    ocm.Parameters.AddWithValue("@p4", OMobile);
                    ocm.Parameters.AddWithValue("@p5", OAddress);
                    ocm.Connection = null;
                    ocm.Connection = ocn;
                    ocn.Open();
                    ocm.ExecuteNonQuery();
                    ocn.Close();
                    ocm.Dispose();
                    ocn.Dispose();
                    Ado1("SELECT * FROM OZV");
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
            OID = DGW1.CurrentRow.Cells["DID"].Value.ToString();
            OLName = DGW1.CurrentRow.Cells["DLName"].Value.ToString();
            ONameFather = DGW1.CurrentRow.Cells["DNameFather"].Value.ToString();
            OMobile = DGW1.CurrentRow.Cells["DMobile"].Value.ToString();
            OAddress = DGW1.CurrentRow.Cells["DAddress"].Value.ToString();
            SabtOzv ShowEditOZV = new SabtOzv();
            ShowEditOZV.txtID.Text = OID;
            ShowEditOZV.txtLName.Text = OLName;
            ShowEditOZV.txtFather.Text = ONameFather;
            ShowEditOZV.txtMobile.Text = OMobile;
            ShowEditOZV.txtAddress.Text = OAddress;
            ShowEditOZV.Add_Edit = false;
            ShowEditOZV.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (comboSelect.SelectedIndex)
            {
                case 0:
                    Ado1("SELECT * FROM OZV WHERE LName LIKE '" + txtSearch.Text + "%'");
                    break;
                case 1:
                    Ado1("SELECT * FROM OZV WHERE NameFather LIKE '" + txtSearch.Text + "%'");
                    break;
                case 2:
                    Ado1("SELECT * FROM OZV WHERE Mobile LIKE '" + txtSearch.Text + "%'");
                    break;
            }
        }

        private void DGW1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
