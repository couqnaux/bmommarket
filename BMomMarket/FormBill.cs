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
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
            loadOrders();
        }

        void loadOrders()
        {
            var db = new BmomMarketContext();

            var ls = (from order in db.Orders
                      join customer in db.Customers on order.CustomerId equals customer.CustomerId
                      join employee in db.Employees on order.EmployeeId equals employee.EmployeeId
                      select new OrderDTO
                      {
                          OrderId = order.OrderId,
                          OrderDate = order.OrderDate,
                          CustomerName = customer.FullName,
                          EmployeeName = employee.FullName,
                          TotalPrice = order.TotalPrice
                      }).OrderByDescending(o => o.OrderId).ToList();
            orderDTOBindingSource.DataSource = ls;
        }
    }
}
