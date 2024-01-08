namespace BMomMarket
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            splitContainer1 = new SplitContainer();
            txtUserName = new TextBox();
            txtPosition = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            label6 = new Label();
            txtEmployeeName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            positionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnUpdate = new ToolStripButton();
            btnResetInput = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeDTOBindingSource).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(txtUserName);
            splitContainer1.Panel1.Controls.Add(txtPosition);
            splitContainer1.Panel1.Controls.Add(txtPassword);
            splitContainer1.Panel1.Controls.Add(txtEmail);
            splitContainer1.Panel1.Controls.Add(txtPhone);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(txtEmployeeName);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label5);
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
            splitContainer1.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(281, 221);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(327, 34);
            txtUserName.TabIndex = 4;
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPosition.Location = new Point(281, 129);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(327, 34);
            txtPosition.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(778, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(248, 34);
            txtPassword.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(778, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 34);
            txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(778, 37);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(248, 34);
            txtPhone.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(644, 224);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 1;
            label6.Text = "Mật khẩu";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeeName.Location = new Point(281, 37);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(327, 34);
            txtEmployeeName.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(644, 132);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 1;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(129, 224);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 1;
            label5.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(644, 40);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 1;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(129, 132);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "Chức vụ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 40);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên nhân viên";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fullNameDataGridViewTextBoxColumn, positionDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            dataGridView1.DataSource = employeeDTOBindingSource;
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
            // positionDataGridViewTextBoxColumn
            // 
            positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            positionDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            positionDataGridViewTextBoxColumn.ReadOnly = true;
            positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "Tài khoản";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDTOBindingSource
            // 
            employeeDTOBindingSource.DataSource = typeof(DTO.EmployeeDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnDelete, btnUpdate, btnResetInput });
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
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 724);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmployee";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtPosition;
        private TextBox txtPhone;
        private TextBox txtEmployeeName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnDelete;
        private ToolStripButton btnUpdate;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label6;
        private Label label5;
        private BindingSource employeeDTOBindingSource;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private ToolStripButton btnResetInput;
    }
}