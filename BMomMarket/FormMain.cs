using BMomMarket.Model;
using BMomMarket.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace BMomMarket
{
    public partial class FormMain : Form
    {
        EmployeeDTO user;

        public FormMain(EmployeeDTO user)
        {
            InitializeComponent();
            this.user = user;
            setLblName();
            showDashBoard();
        }

        void setLblName()
        {
            var db = new BmomMarketContext();
            Employee nhanVien = db.Employees.Where(c => c.UserName == user.UserName).FirstOrDefault();
            if (nhanVien != null)
            {
                lblName.Text = nhanVien.FullName;
            }
        }

        void showDashBoard()
        {
            var db = new BmomMarketContext();
            DateTime today = DateTime.Now.Date;
            int numberOfOrders = db.Orders.Count(o => o.OrderDate.HasValue && o.OrderDate.Value.Date == today);
            btnBills.Text = "Số đơn hàng hôm nay: " + numberOfOrders.ToString();
            long total = db.Orders
                .Where(o => o.OrderDate.HasValue && o.OrderDate.Value.Date == today)
                .Sum(o => o.TotalPrice ?? 0);
            btnTotal.Text = "Doanh thu hôm nay: " + total.ToString();
        }

        void showForm(Form f)
        {
            pnForm.Controls.Clear();
            f.TopLevel = false;
            pnForm.Controls.Add(f);
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPOS formPOS = new FormPOS(user);
            formPOS.ShowDialog();
            this.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            showForm(formProduct);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            FormBill formBill = new FormBill();
            showForm(formBill);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            showForm(formCustomer);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            showForm(formEmployee);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            FormStats formStats = new FormStats();
            showForm(formStats);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain(user);
            this.Hide();
            f.ShowDialog();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FormBill formBill = new FormBill();
            showForm(formBill);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            FormStats formStats = new FormStats();
            showForm(formStats);

        }
    }
}
