using BMomMarket.DTO;
using BMomMarket.Model;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMomMarket
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            loadEmployee();
        }
        void loadEmployee()
        {
            var db = new BmomMarketContext();
            var ls = db.Employees.Select(e => new EmployeeDTO
            {
                EmployeeId = e.EmployeeId,
                FullName = e.FullName,
                Position = e.Position,
                PhoneNumber = e.PhoneNumber,
                Email = e.Email,
                UserName = e.UserName,
                Password = e.Password,
            }).ToList();
            employeeDTOBindingSource.DataSource = ls;
        }

        int checkInput()
        {
            if (string.IsNullOrEmpty(txtEmployeeName.Text) || string.IsNullOrEmpty(txtPosition.Text) || string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                return 1;
            }
            return 0;
        }

        void ResetInput()
        {
            txtEmployeeName.Text = "";
            txtPosition.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInput() == 1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var db = new BmomMarketContext();
                var user = db.Employees.Where(e => e.UserName.Equals(txtUserName.Text)).FirstOrDefault();
                if (user != null)
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Text = "";
                }
                else
                {
                    Employee newEmployee = new Employee
                    {
                        FullName = txtEmployeeName.Text,
                        Position = txtPosition.Text,
                        PhoneNumber = txtPhone.Text,
                        Email = txtEmail.Text,
                        UserName = txtUserName.Text,
                        Password = txtPassword.Text,
                    };
                    db.Add(newEmployee);
                    db.SaveChanges();
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetInput();
                    loadEmployee();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selEmployee = employeeDTOBindingSource.Current as EmployeeDTO;
            if (selEmployee != null)
            {
                var rs = MessageBox.Show("Đồng ý xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new BmomMarketContext();
                    var obj = db.Employees.Where(t => t.EmployeeId == selEmployee.EmployeeId).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Remove(obj);
                        db.SaveChanges();
                        loadEmployee();
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkInput() == 1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var db = new BmomMarketContext();
                var selEmployee = employeeDTOBindingSource.Current as EmployeeDTO;
                Employee employee = db.Employees.Where(t => t.EmployeeId == selEmployee.EmployeeId).FirstOrDefault();

                if (employee == null)
                {
                    MessageBox.Show("Nhân viên  không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                employee.FullName = txtEmployeeName.Text;
                employee.Position = txtPosition.Text;
                employee.UserName = txtUserName.Text;
                employee.Password = txtPassword.Text;
                employee.PhoneNumber = txtPhone.Text;
                employee.Email = txtEmail.Text;

                db.SaveChanges();
                loadEmployee();
                MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetInput();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
            {
                return;
            }
            row = dataGridView1.Rows[e.RowIndex];
            EmployeeDTO employee = (EmployeeDTO)row.DataBoundItem;
            txtEmployeeName.Text = employee.FullName;
            txtPosition.Text = employee.Position;
            txtUserName.Text = employee.UserName;
            txtPassword.Text = employee.Password;
            txtPhone.Text = employee.PhoneNumber;
            txtEmail.Text = employee.Email;
        }

        private void btnResetInput_Click(object sender, EventArgs e)
        {
            ResetInput();
        }
    }
}
