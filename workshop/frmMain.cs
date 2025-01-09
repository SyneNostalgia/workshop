using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workshop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void workshop3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerByCountry frm = new FrmCustomerByCountry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            work6 frm = new work6();
            frm.MdiParent = this;
            frm.Show();
        }

        private void jihanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageProduct frm = new frmManageProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void from5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.MdiParent = this;
            frm.Show();
        }

        private void from6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
