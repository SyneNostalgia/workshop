using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static workshop.Form1;

namespace workshop
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void ShowE()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlE = "Select EmployeeID, (TitleOfCourtesy+FirstName+SPACE(2)+LastName) As EmployeeName From Employees";

            SqlDataAdapter da = new SqlDataAdapter(sqlE, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboEmployee.DataSource = dt;
            cboEmployee.ValueMember = "EmployeeID";
            cboEmployee.DisplayMember = "EmployeeName";

            conn.Close();
        }
        public void ShowC()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlE = "Select ShipCountry From Orders Group By ShipCountry Order By ShipCountry ASC;";

            SqlDataAdapter da = new SqlDataAdapter(sqlE, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCountry.DataSource = dt;
            cboCountry.ValueMember = "ShipCountry";
            cboCountry.DisplayMember = "ShipCountry";

            conn.Close();
        }
        public void ShowO(int EID, string C)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlOrder = String.Format("Select * From Orders Where EmployeeID = {0} AND ShipCountry = '{1}';", EID, C);

            SqlDataAdapter da = new SqlDataAdapter(sqlOrder, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvOrder.DataSource = dt;
            conn.Close();
        }

        public void ShowO()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlOrder = String.Format("Select * From Orders;");

            SqlDataAdapter da = new SqlDataAdapter(sqlOrder, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvOrder.DataSource = dt;
            conn.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ShowE();
            ShowC();
            ShowO();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int EID = Convert.ToInt32(cboEmployee.SelectedValue);
            string C = cboCountry.SelectedValue.ToString();
            ShowO(EID, C);
        }

        private void dgvOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int r = e.RowIndex;
            int orderID = Convert.ToInt32(dgvOrder.Rows[r].Cells[0].Value);
            showOrderDetail(orderID);
        }

        public void showOrderDetail(int orderID)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlDetail = String.Format("Select * From OrderDetailVeiw WHERE OrderID = {0};", orderID);

            SqlDataAdapter da = new SqlDataAdapter(sqlDetail, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDetail.DataSource = dt;
            conn.Close();
        }
    }
}
