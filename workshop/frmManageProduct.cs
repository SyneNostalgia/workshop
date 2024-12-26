using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data.Common;
using static workshop.Form1;
using System.Xml.Linq;

namespace workshop
{
    public partial class frmManageProduct : Form
    {
        public frmManageProduct()
        {
            InitializeComponent();
        }
        public void ShowProducts()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = String.Format("Select * From Products");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvResult.DataSource = dt;
            dgvResult.Columns[2].Visible = false;
            dgvResult.Columns[4].Visible = false;
            conn.Close();
        }

        private void ClearForm()
        {
            txtPid.Clear();
            txtPname.Clear();
            txtDes.Clear();
            txtPrice.Clear();
            cboCid.SelectedIndex = 0;
        }

        private void ShowCategory()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = "Select * From Categories Order By categoryName ASC";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboCid.DataSource = dt;
            cboCid.ValueMember = "categoryID";
            cboCid.DisplayMember = "categoryName";
        }

        private void frmManageProduct_Load(object sender, EventArgs e)
        {
            ShowProducts();
            ShowCategory();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvResult_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            txtPid.Text = dgvResult.Rows[row].Cells[0].Value.ToString();
            txtPname.Text = dgvResult.Rows[row].Cells[1].Value.ToString();
            txtDes.Text = dgvResult.Rows[row].Cells[2].Value.ToString();
            txtPrice.Text = dgvResult.Rows[row].Cells[3].Value.ToString();
            cboCid.SelectedValue = dgvResult.Rows[row].Cells[4].Value;
        }
        public void InsertProduct()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = "insert into Products(productName,detail,unitprice,categoryID)values(@p_name,@p_des,@p_price,@c_id);";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@p_name", txtPname.Text);
            com.Parameters.AddWithValue("@p_des", txtDes.Text);
            com.Parameters.Add("@p_price", SqlDbType.Money).Value = txtPrice.Text;
            com.Parameters.Add("@c_id", SqlDbType.Int).Value = cboCid.SelectedValue;

            com.ExecuteNonQuery();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPname.Text.Equals("") || txtPname.Text.Equals(null))
            {
                MessageBox.Show("ชื่อสินค้าห้ามเป็นค่าว่าง");
                return;
            }
            InsertProduct();
            ShowProducts();
            ClearForm();
        }

        private void UpdateProduct(int p_id)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = "Update Products set productName = @p_name, detail = @p_des, unitprice = @p_price, categoryID = @c_id Where productID = @p_id";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@p_name", txtPname.Text);
            com.Parameters.AddWithValue("@p_des", txtDes.Text);
            com.Parameters.Add("@p_price", SqlDbType.Money).Value = txtPrice.Text;
            com.Parameters.Add("@c_id", SqlDbType.Int).Value = cboCid.SelectedValue;
            com.Parameters.Add("@p_id", SqlDbType.Int).Value = p_id;

            com.ExecuteNonQuery();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPname.Text.Equals("") || txtPname.Text.Equals(null))
            {
                MessageBox.Show("ชื่อสินค้าห้ามเป็นค่าว่าง");
                return;
            }
            int p_id = Convert.ToInt32(txtPid.Text);
            UpdateProduct(p_id);
            ShowProducts();
            ClearForm();
        }
        private void DeleteProduct(int p_id)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = String.Format("Delete From Products Where productID = {0}",p_id);
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPid.Text.Equals(""))
            {
                return;
            }
            if (MessageBox.Show("คุณต้องการลบรายการสินค้านี้หรือไม่" , "ยืนยันการทำงาน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            int p_id = Convert.ToInt32(txtPid.Text);
            DeleteProduct(p_id);
            ShowProducts();
            ClearForm();
        }
    }
}
