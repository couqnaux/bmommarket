namespace BMomMarket
{
    partial class FormBill
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
            dataGridView1 = new DataGridView();
            orderDTOBindingSource = new BindingSource(components);
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderIdDataGridViewTextBoxColumn, orderDateDataGridViewTextBoxColumn, customerNameDataGridViewTextBoxColumn, employeeNameDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = orderDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1172, 724);
            dataGridView1.TabIndex = 0;
            // 
            // orderDTOBindingSource
            // 
            orderDTOBindingSource.DataSource = typeof(DTO.OrderDTO);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            customerNameDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            customerNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            employeeNameDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            employeeNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // FormBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 724);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBill";
            Text = "FormBill";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private BindingSource orderDTOBindingSource;
    }
}