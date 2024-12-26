namespace workshop
{
    partial class frmManageProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            cboCid = new ComboBox();
            txtPrice = new TextBox();
            txtDes = new TextBox();
            txtPname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPid = new TextBox();
            label1 = new Label();
            dgvResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(717, 302);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(71, 136);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(640, 302);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(71, 136);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "แก้ไข";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(563, 302);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(71, 136);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "เพิ่ม";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(486, 302);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(71, 136);
            btnClear.TabIndex = 26;
            btnClear.Text = "เคลียร์";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cboCid
            // 
            cboCid.FormattingEnabled = true;
            cboCid.Location = new Point(579, 252);
            cboCid.Name = "cboCid";
            cboCid.Size = new Size(209, 28);
            cboCid.TabIndex = 25;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(579, 210);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 24;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(579, 100);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(209, 95);
            txtDes.TabIndex = 23;
            // 
            // txtPname
            // 
            txtPname.Location = new Point(579, 56);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(209, 27);
            txtPname.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(482, 255);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 21;
            label5.Text = "ประเภทสินค้า :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 59);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 20;
            label4.Text = "ชื่อสินค้า :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 103);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 19;
            label3.Text = "รายละเอียด :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(528, 210);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 18;
            label2.Text = "ราคา :";
            // 
            // txtPid
            // 
            txtPid.Location = new Point(579, 18);
            txtPid.Name = "txtPid";
            txtPid.ReadOnly = true;
            txtPid.Size = new Size(125, 27);
            txtPid.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(501, 21);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 16;
            label1.Text = "รหัสสินค้า :";
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 12);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(454, 426);
            dgvResult.TabIndex = 15;
            dgvResult.CellMouseDoubleClick += dgvResult_CellMouseDoubleClick;
            // 
            // frmManageProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(cboCid);
            Controls.Add(txtPrice);
            Controls.Add(txtDes);
            Controls.Add(txtPname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPid);
            Controls.Add(label1);
            Controls.Add(dgvResult);
            Name = "frmManageProduct";
            Text = "frmManageProduct";
            Load += frmManageProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private ComboBox cboCid;
        private TextBox txtPrice;
        private TextBox txtDes;
        private TextBox txtPname;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPid;
        private Label label1;
        private DataGridView dgvResult;
    }
}