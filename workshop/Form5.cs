using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static workshop.Form1;

namespace workshop
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            showOrder();
        }
        public void showOrder()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = "Select * From Order_View" ;

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvOrder.DataSource = dt;
            conn.Close();
        }
        public void showOrderDetail(int orderID)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlDetail = String.Format("SELECT OD.OrderID, OD.ProductID, P.ProductName, C.CategoryName, OD.UnitPrice, OD.Quantity, (OD.UnitPrice * OD.Quantity) AS Sumprice, OD.Discount, (OD.UnitPrice * OD.Quantity * OD.Discount) AS DiscountPrice, (OD.UnitPrice * OD.Quantity) - (OD.UnitPrice * OD.Quantity * OD.Discount) AS NetPrice FROM [Order Details] AS OD inner join Products AS P ON OD.ProductID = P.ProductID inner join Categories As C ON P.CategoryID = C.CategoryID WHERE OrderID = {0};", orderID);

            SqlDataAdapter da = new SqlDataAdapter(sqlDetail, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDetail.DataSource = dt;
            conn.Close();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int r = e.RowIndex;
            int orderID = Convert.ToInt32(dgvOrder.Rows[r].Cells[0].Value);
            showOrderDetail(orderID);
        }
    }
}
