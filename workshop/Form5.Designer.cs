namespace workshop
{
    partial class Form5
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
            dgvOrder = new DataGridView();
            dgvDetail = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(12, 32);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(1027, 281);
            dgvOrder.TabIndex = 0;
            dgvOrder.UseWaitCursor = true;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            dgvOrder.CellMouseClick += dgvOrder_CellMouseClick;
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(12, 349);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.Size = new Size(1027, 230);
            dgvDetail.TabIndex = 1;
            dgvDetail.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "ใบสั่งซื้อ";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 326);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "รายการสั่งซื้อ";
            label2.UseWaitCursor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 591);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDetail);
            Controls.Add(dgvOrder);
            Name = "Form5";
            Text = "Form5";
            WindowState = FormWindowState.Maximized;
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrder;
        private DataGridView dgvDetail;
        private Label label1;
        private Label label2;
    }
}