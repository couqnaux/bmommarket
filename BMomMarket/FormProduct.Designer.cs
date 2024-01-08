namespace BMomMarket
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            splitContainer1 = new SplitContainer();
            rtbDescription = new RichTextBox();
            cbbCategory = new ComboBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            picProduct = new PictureBox();
            dataGridView1 = new DataGridView();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnUpdate = new ToolStripButton();
            btnResetInput = new ToolStripButton();
            btnShowAll = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(rtbDescription);
            splitContainer1.Panel1.Controls.Add(cbbCategory);
            splitContainer1.Panel1.Controls.Add(txtQuantity);
            splitContainer1.Panel1.Controls.Add(txtPrice);
            splitContainer1.Panel1.Controls.Add(txtProductName);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(picProduct);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(toolStrip1);
            splitContainer1.Size = new Size(1172, 724);
            splitContainer1.SplitterDistance = 279;
            splitContainer1.TabIndex = 0;
            // 
            // rtbDescription
            // 
            rtbDescription.BorderStyle = BorderStyle.FixedSingle;
            rtbDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDescription.Location = new Point(370, 104);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(327, 113);
            rtbDescription.TabIndex = 2;
            rtbDescription.Text = "";
            // 
            // cbbCategory
            // 
            cbbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(370, 230);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(327, 36);
            cbbCategory.TabIndex = 4;
            cbbCategory.SelectedIndexChanged += cbbCategory_SelectedIndexChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(839, 136);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(227, 34);
            txtQuantity.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(839, 44);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(227, 34);
            txtPrice.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(370, 44);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(327, 34);
            txtProductName.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(733, 139);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 1;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(733, 47);
            label3.Name = "label3";
            label3.Size = new Size(41, 28);
            label3.TabIndex = 1;
            label3.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(234, 230);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 1;
            label5.Text = "Danh mục";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(234, 139);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 1;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 47);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên sản phẩm";
            // 
            // picProduct
            // 
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Image = (Image)resources.GetObject("picProduct.Image");
            picProduct.Location = new Point(12, 47);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(174, 170);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 0;
            picProduct.TabStop = false;
            picProduct.Click += picProduct_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productNameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1172, 414);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Tên sản ";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 450;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Giá";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDTOBindingSource
            // 
            productDTOBindingSource.DataSource = typeof(DTO.ProductDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnDelete, btnUpdate, btnResetInput, btnShowAll });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1172, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 24);
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
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
            // btnUpdate
            // 
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageTransparentColor = Color.Magenta;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(58, 24);
            btnUpdate.Text = "Sửa";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnResetInput
            // 
            btnResetInput.Image = (Image)resources.GetObject("btnResetInput.Image");
            btnResetInput.ImageTransparentColor = Color.Magenta;
            btnResetInput.Name = "btnResetInput";
            btnResetInput.Size = new Size(119, 24);
            btnResetInput.Text = "Nhập dữ liệu";
            btnResetInput.Click += btnResetInput_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Image = (Image)resources.GetObject("btnShowAll.Image");
            btnShowAll.ImageTransparentColor = Color.Magenta;
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(141, 24);
            btnShowAll.Text = "Tất cả sản phẩm";
            btnShowAll.Click += btnShowAll_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 724);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProduct";
            Text = "FormProduct";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private BindingSource productDTOBindingSource;
        private PictureBox picProduct;
        private Label label1;
        private TextBox txtProductName;
        private Label label3;
        private Label label2;
        private Label label4;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnDelete;
        private ToolStripButton btnUpdate;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private ComboBox cbbCategory;
        private Label label5;
        private RichTextBox rtbDescription;
        private ToolStripButton btnShowAll;
        private ToolStripButton btnResetInput;
    }
}