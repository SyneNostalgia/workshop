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
    public partial class work6 : Form
    {
        public work6()
        {
            InitializeComponent();
        }

        private void work6_Load(object sender, EventArgs e)
        {
            showCategory();
            showProduct();
        }
        public void showCategory()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string query = "SELECT CategoryID, CategoryName FROM Categories Order By CategoryName ASC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "------ แสดงทุกประเภทสินค้า ------";
            dt.Rows.InsertAt(row, 0);

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "CategoryName";
            comboBox1.DisplayMember = "CategoryID";

            conn.Close();
        }
        public void showProduct(int cid)
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            string query = string.Format("Select * From Products Where CategoryID = {0}", cid);

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();

        }

        public void showProduct()
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            string query = "Select * From Products";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                showProduct();
            }
            else
            {
                int cid = comboBox1.SelectedIndex;
                showProduct(cid);
            }
        }
    }
}
