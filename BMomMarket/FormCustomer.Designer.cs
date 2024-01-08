namespace BMomMarket
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            splitContainer1 = new SplitContainer();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtCustomerName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAdd = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnUpdate = new ToolStripButton();
            btnResetInput = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerDTOBindingSource).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(txtAddress);
            splitContainer1.Panel1.Controls.Add(txtPhone);
            splitContainer1.Panel1.Controls.Add(txtCustomerName);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(toolStrip1);
            splitContainer1.Size = new Size(1172, 724);
            splitContainer1.SplitterDistance = 279;
            splitContainer1.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(269, 213);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(327, 34);
            txtAddress.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(766, 121);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(248, 34);
            txtPhone.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerName.Location = new Point(269, 121);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(327, 34);
            txtCustomerName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(632, 124);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 1;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 216);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 1;
            label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 124);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên khách hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fullNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            dataGridView1.DataSource = customerDTOBindingSource;
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
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            fullNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDTOBindingSource
            // 
            customerDTOBindingSource.DataSource = typeof(DTO.CustomerDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAdd, btnDelete, btnUpdate, btnResetInput });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1172, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(74, 24);
            btnReturn.Text = "Trở lại";
            btnReturn.Click += btnReturn_Click;
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
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 724);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCustomer";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ComboBox cbbCategory;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtAddress;
        private TextBox txtCustomerName;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnDelete;
        private ToolStripButton btnUpdate;
        private TextBox txtPhone;
        private BindingSource customerDTOBindingSource;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private ToolStripButton btnReturn;
        private ToolStripButton btnResetInput;
    }
}