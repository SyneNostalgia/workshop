namespace workshop
{
    partial class Form6
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
            label2 = new Label();
            label1 = new Label();
            dgvDetail = new DataGridView();
            dgvOrder = new DataGridView();
            btnShow = new Button();
            cboEmployee = new ComboBox();
            cboCountry = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 306);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "รายการสั่งซื้อ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 6;
            label1.Text = "ใบสั่งซื้อ";
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(12, 329);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.Size = new Size(776, 144);
            dgvDetail.TabIndex = 5;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(12, 67);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(776, 236);
            dgvOrder.TabIndex = 4;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(700, 5);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 8;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // cboEmployee
            // 
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(130, 6);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(190, 28);
            cboEmployee.TabIndex = 9;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(452, 6);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(242, 28);
            cboCountry.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 11;
            label3.Text = "เลือกพนักงานขาย";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 9);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 12;
            label4.Text = "เลือกประเทศที่จัดส่ง";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 483);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboCountry);
            Controls.Add(cboEmployee);
            Controls.Add(btnShow);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDetail);
            Controls.Add(dgvOrder);
            Name = "Form6";
            Text = "Form6";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dgvDetail;
        private DataGridView dgvOrder;
        private Button btnShow;
        private ComboBox cboEmployee;
        private ComboBox cboCountry;
        private Label label3;
        private Label label4;
    }
}