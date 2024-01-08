namespace BMomMarket
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            lblName = new Label();
            picLogo = new PictureBox();
            btnStats = new Button();
            btnEmployee = new Button();
            btnCustomer = new Button();
            btnBill = new Button();
            btnProduct = new Button();
            btnPOS = new Button();
            pnForm = new Panel();
            btnTotal = new Button();
            btnBills = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(picLogo);
            panel1.Controls.Add(btnStats);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnBill);
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(btnPOS);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 748);
            panel1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(255, 128, 0);
            lblName.Location = new Point(91, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Tên dn";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(85, 78);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // btnStats
            // 
            btnStats.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnStats.Image = (Image)resources.GetObject("btnStats.Image");
            btnStats.ImageAlign = ContentAlignment.TopCenter;
            btnStats.Location = new Point(19, 630);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(200, 100);
            btnStats.TabIndex = 5;
            btnStats.Text = "Thống kê";
            btnStats.TextAlign = ContentAlignment.BottomCenter;
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.TopCenter;
            btnEmployee.Location = new Point(19, 524);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(200, 100);
            btnEmployee.TabIndex = 4;
            btnEmployee.Text = "Nhân viên";
            btnEmployee.TextAlign = ContentAlignment.BottomCenter;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.TopCenter;
            btnCustomer.Location = new Point(19, 418);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(200, 100);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.TextAlign = ContentAlignment.BottomCenter;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnBill
            // 
            btnBill.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBill.Image = (Image)resources.GetObject("btnBill.Image");
            btnBill.ImageAlign = ContentAlignment.TopCenter;
            btnBill.Location = new Point(19, 312);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(200, 100);
            btnBill.TabIndex = 2;
            btnBill.Text = "Hóa đơn";
            btnBill.TextAlign = ContentAlignment.BottomCenter;
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.TopCenter;
            btnProduct.Location = new Point(19, 206);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(200, 100);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Hàng hóa";
            btnProduct.TextAlign = ContentAlignment.BottomCenter;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnPOS
            // 
            btnPOS.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPOS.Image = (Image)resources.GetObject("btnPOS.Image");
            btnPOS.ImageAlign = ContentAlignment.TopCenter;
            btnPOS.Location = new Point(19, 100);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(200, 100);
            btnPOS.TabIndex = 0;
            btnPOS.Text = "POS";
            btnPOS.TextAlign = ContentAlignment.BottomCenter;
            btnPOS.UseVisualStyleBackColor = true;
            btnPOS.Click += btnPOS_Click;
            // 
            // pnForm
            // 
            pnForm.Controls.Add(btnTotal);
            pnForm.Controls.Add(btnBills);
            pnForm.Dock = DockStyle.Fill;
            pnForm.Location = new Point(269, 0);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(1193, 748);
            pnForm.TabIndex = 0;
            // 
            // btnTotal
            // 
            btnTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTotal.Image = (Image)resources.GetObject("btnTotal.Image");
            btnTotal.ImageAlign = ContentAlignment.TopCenter;
            btnTotal.Location = new Point(566, 194);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(375, 358);
            btnTotal.TabIndex = 0;
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnBills
            // 
            btnBills.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBills.Image = (Image)resources.GetObject("btnBills.Image");
            btnBills.ImageAlign = ContentAlignment.TopCenter;
            btnBills.Location = new Point(157, 194);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(375, 358);
            btnBills.TabIndex = 0;
            btnBills.UseVisualStyleBackColor = true;
            btnBills.Click += btnBills_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 748);
            Controls.Add(pnForm);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMomMarket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPOS;
        private Panel pnForm;
        private Button btnEmployee;
        private Button btnBill;
        private Button btnProduct;
        private Label lblName;
        private Button btnCustomer;
        private Button btnStats;
        private PictureBox picLogo;
        private Button btnTotal;
        private Button btnBills;
    }
}