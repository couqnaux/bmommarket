using BMomMarket.Model;
using BMomMarket.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMomMarket
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtun.Text;
            string password = txtpass.Text;

            var db = new BmomMarketContext();
            var user = db.Employees.Where(c => c.UserName == username && c.Password == password)
                .Select(c => new EmployeeDTO
                {
                    EmployeeId = c.EmployeeId,
                    FullName = c.FullName,
                    Position = c.Position,
                    UserName = c.UserName,
                    Password = c.Password,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber,
                }).SingleOrDefault();

            if (user != null)
            {
                if (user.Position.Equals("Quản lý"))
                {
                    FormMain f = new FormMain(user);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (user.Position.Equals("Nhân viên"))
                {
                    FormPOS f = new FormPOS(user);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !");
            }
        }
    }
}
