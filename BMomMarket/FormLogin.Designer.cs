namespace BMomMarket
{
    partial class FormLogin
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtun = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txtpass = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            btnLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(119, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 83);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 22);
            label1.Name = "label1";
            label1.Size = new Size(200, 41);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtun);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(119, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(563, 63);
            panel2.TabIndex = 3;
            // 
            // txtun
            // 
            txtun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtun.Location = new Point(190, 17);
            txtun.Name = "txtun";
            txtun.Size = new Size(260, 34);
            txtun.TabIndex = 0;
            txtun.Text = "admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 20);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtpass);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(119, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(563, 63);
            panel3.TabIndex = 4;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.Location = new Point(190, 18);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(260, 34);
            txtpass.TabIndex = 0;
            txtpass.Text = "admin";
            txtpass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(69, 21);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLogin);
            panel4.Location = new Point(119, 344);
            panel4.Name = "panel4";
            panel4.Size = new Size(563, 63);
            panel4.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(208, 17);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 43);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtun;
        private Label label2;
        private Panel panel3;
        private TextBox txtpass;
        private Label label3;
        private Panel panel4;
        private Button btnLogin;
    }
}