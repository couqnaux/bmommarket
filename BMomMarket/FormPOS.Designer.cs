namespace BMomMarket
{
    partial class FormPOS
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPOS));
            flpProduct = new FlowLayoutPanel();
            panel1 = new Panel();
            btnRefresh = new Button();
            btnFormCustomer = new Button();
            label2 = new Label();
            lblOrderID = new Label();
            label1 = new Label();
            cbbCustomer = new ComboBox();
            lblName = new Label();
            panel2 = new Panel();
            txtTotal = new TextBox();
            label6 = new Label();
            btnThanhToan = new Button();
            panel3 = new Panel();
            tblBill = new DataGridView();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDetailDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnUpdate = new ToolStripButton();
            btnDelete = new ToolStripButton();
            orderDetailDTOBindingSource1 = new BindingSource(components);
            txtQuantity = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSearch = new TextBox();
            label5 = new Label();
            cbbCategory = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailDTOBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // flpProduct
            // 
            flpProduct.AutoScroll = true;
            flpProduct.Location = new Point(616, 129);
            flpProduct.Name = "flpProduct";
            flpProduct.Size = new Size(893, 600);
            flpProduct.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnFormCustomer);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblOrderID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbbCustomer);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 84);
            panel1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(381, 41);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(30, 30);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "🔃";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFormCustomer
            // 
            btnFormCustomer.Location = new Point(417, 41);
            btnFormCustomer.Name = "btnFormCustomer";
            btnFormCustomer.Size = new Size(30, 30);
            btnFormCustomer.TabIndex = 3;
            btnFormCustomer.Text = "➕";
            btnFormCustomer.UseVisualStyleBackColor = true;
            btnFormCustomer.Click += btnFormCustomer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 41);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 2;
            label2.Text = "Khách hàng:";
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderID.Location = new Point(370, 0);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(127, 28);
            lblOrderID.TabIndex = 2;
            lblOrderID.Text = "Mã hóa đơn: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 2;
            label1.Text = "Nhân viên:";
            // 
            // cbbCustomer
            // 
            cbbCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCustomer.FormattingEnabled = true;
            cbbCustomer.Location = new Point(152, 38);
            cbbCustomer.Name = "cbbCustomer";
            cbbCustomer.Size = new Size(212, 36);
            cbbCustomer.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(152, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 28);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnThanhToan);
            panel2.Location = new Point(12, 662);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 67);
            panel2.TabIndex = 2;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(124, 15);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(186, 34);
            txtTotal.TabIndex = 2;
            txtTotal.Text = "0";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 19);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 1;
            label6.Text = "Tổng tiền:";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThanhToan.Location = new Point(467, 12);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(128, 40);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tblBill);
            panel3.Controls.Add(toolStrip1);
            panel3.Location = new Point(12, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(598, 554);
            panel3.TabIndex = 3;
            // 
            // tblBill
            // 
            tblBill.AllowUserToAddRows = false;
            tblBill.AllowUserToDeleteRows = false;
            tblBill.AutoGenerateColumns = false;
            tblBill.BackgroundColor = Color.FromArgb(192, 192, 255);
            tblBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblBill.Columns.AddRange(new DataGridViewColumn[] { productNameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            tblBill.DataSource = orderDetailDTOBindingSource;
            tblBill.Dock = DockStyle.Fill;
            tblBill.Location = new Point(0, 27);
            tblBill.Name = "tblBill";
            tblBill.ReadOnly = true;
            tblBill.RowHeadersWidth = 51;
            tblBill.RowTemplate.Height = 29;
            tblBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblBill.Size = new Size(598, 527);
            tblBill.TabIndex = 0;
            tblBill.CellClick += tblBill_CellClick;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Sản phẩm";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDetailDTOBindingSource
            // 
            orderDetailDTOBindingSource.DataSource = typeof(DTO.OrderDetailDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnUpdate, btnDelete });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(598, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnUpdate
            // 
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageTransparentColor = Color.Magenta;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(58, 24);
            btnUpdate.Text = "Sửa";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(59, 24);
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // orderDetailDTOBindingSource1
            // 
            orderDetailDTOBindingSource1.DataSource = typeof(DTO.OrderDetailDTO);
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(635, 62);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(138, 34);
            txtQuantity.TabIndex = 0;
            txtQuantity.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(635, 21);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 2;
            label3.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(807, 21);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 2;
            label4.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(807, 62);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(268, 34);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1106, 21);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 2;
            label5.Text = "Danh mục:";
            // 
            // cbbCategory
            // 
            cbbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(1106, 62);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(228, 36);
            cbbCategory.TabIndex = 2;
            cbbCategory.SelectedIndexChanged += cbbCategory_SelectedIndexChanged;
            // 
            // FormPOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 741);
            Controls.Add(cbbCategory);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flpProduct);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPOS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPOS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailDTOBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpProduct;
        private Panel panel1;
        private Panel panel2;
        private Button btnThanhToan;
        private Panel panel3;
        private DataGridView tblBill;
        private BindingSource orderDetailDTOBindingSource;
        private BindingSource orderDetailDTOBindingSource1;
        private TextBox txtQuantity;
        private Label lblName;
        private ComboBox cbbCustomer;
        private ToolStrip toolStrip1;
        private ToolStripButton btnUpdate;
        private ToolStripButton btnDelete;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private Button btnFormCustomer;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtSearch;
        private Label label5;
        private ComboBox cbbCategory;
        private Label label6;
        private TextBox txtTotal;
        private Label lblOrderID;
        private Button btnRefresh;
    }
}