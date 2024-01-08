using BMomMarket.DTO;
using BMomMarket.Model;
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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
            loadCustomer();
        }

        void loadCustomer()
        {
            var db = new BmomMarketContext();
            var ls = db.Customers.Select(e => new CustomerDTO
            {
                CustomerId = e.CustomerId,
                FullName = e.FullName,
                PhoneNumber = e.PhoneNumber,
                Address = e.Address,
            }).ToList();
            customerDTOBindingSource.DataSource = ls;
        }

        int checkInput()
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                return 1;
            }
            return 0;
        }

        void ResetInput()
        {
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
            {
                return;
            }
            row = dataGridView1.Rows[e.RowIndex];
            CustomerDTO customer = (CustomerDTO)row.DataBoundItem;
            txtCustomerName.Text = customer.FullName;
            txtAddress.Text = customer.Address;
            txtPhone.Text = customer.PhoneNumber;
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
                Customer newCustomer = new Customer
                {
                    FullName = txtCustomerName.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhone.Text,
                };
                db.Add(newCustomer);
                db.SaveChanges();
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetInput();
                loadCustomer();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selCustomer = customerDTOBindingSource.Current as CustomerDTO;
            if (selCustomer != null)
            {
                var rs = MessageBox.Show("Đồng ý xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new BmomMarketContext();
                    var obj = db.Customers.Where(t => t.CustomerId == selCustomer.CustomerId).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Remove(obj);
                        db.SaveChanges();
                        loadCustomer();
                        MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var selCustomer = customerDTOBindingSource.Current as CustomerDTO;
                Customer customer = db.Customers.Where(t => t.CustomerId == selCustomer.CustomerId).FirstOrDefault();

                if (customer == null)
                {
                    MessageBox.Show("Khách hàng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                customer.FullName = txtCustomerName.Text;
                customer.Address = txtAddress.Text;
                customer.PhoneNumber = txtPhone.Text;

                db.SaveChanges();
                loadCustomer();
                MessageBox.Show("Cập nhật thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetInput();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnResetInput_Click(object sender, EventArgs e)
        {
            ResetInput();
        }

    }
}
