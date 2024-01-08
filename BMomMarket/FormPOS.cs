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

namespace BMomMarket
{
    public partial class FormPOS : Form
    {
        EmployeeDTO user;
        //long total = 0;
        List<OrderDetailDTO> orderList = new List<OrderDetailDTO>();

        public FormPOS(EmployeeDTO user)
        {
            InitializeComponent();
            lblName.Text = user.FullName;
            this.user = user;
            loadCustomer();
            loadCategory();
            getOrderID();
            LoadProductListByCategoryID(0);
        }

        void loadCustomer()
        {
            var db = new BmomMarketContext();
            var ls = db.Customers.ToList();
            cbbCustomer.DataSource = ls;
            cbbCustomer.DisplayMember = "FullName";
        }

        void loadCategory()
        {
            var db = new BmomMarketContext();
            var ls = db.Categories.ToList();
            cbbCategory.DataSource = ls;
            cbbCategory.DisplayMember = "CategoryName";
        }

        void getOrderID()
        {
            var db = new BmomMarketContext();
            long orderID = db.Orders.Max(o => o.OrderId) + 1;
            lblOrderID.Text = "Mã hóa đơn: " + orderID.ToString();
        }

        void renderProduct(List<ProductDTO> ls)
        {

            flpProduct.Controls.Clear();

            foreach (var productDTO in ls)
            {
                Panel panel = new Panel();
                panel.BackColor = Color.FromArgb(192, 192, 255);
                panel.Width = 200;
                panel.Height = 300;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 200;
                pictureBox.Height = 150;
                pictureBox.Dock = DockStyle.Top;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = Image.FromFile(productDTO.Image);

                Button btn = new Button();
                btn.Tag = productDTO;
                btn.Width = 200;
                btn.Height = 150;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Text = productDTO.ProductName + Environment.NewLine + "Tồn kho: " + productDTO.Quantity + " - Giá: " + productDTO.Price;
                btn.Dock = DockStyle.Bottom;
                btn.Click += Btn_Click;

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(btn);

                flpProduct.Controls.Add(panel);

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var db = new BmomMarketContext();
            var product = (sender as Button).Tag as ProductDTO;
            if (product != null)
            {
                if (product.Quantity < long.Parse(txtQuantity.Text))
                {
                    MessageBox.Show("Không đủ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    OrderDetailDTO orderDetailDTO = new OrderDetailDTO
                    {
                        ProductID = product.ProductId,
                        ProductName = product.ProductName,
                        Price = (long)product.Price,
                        Quantity = long.Parse(txtQuantity.Text.Trim()),
                        TotalPrice = (long)product.Price * long.Parse(txtQuantity.Text),
                        OrderID = db.Orders.Max(c => c.OrderId) + 1
                    };
                    var item = orderList.Where(dt => dt.ProductID == product.ProductId).FirstOrDefault();
                    if (item != null)
                    {
                        item.Quantity = long.Parse(txtQuantity.Text);
                        item.TotalPrice = (long)product.Price * long.Parse(txtQuantity.Text);
                    }
                    else
                    {
                        orderList.Add(orderDetailDTO);
                    }
                    orderDetailDTOBindingSource.DataSource = null;
                    orderDetailDTOBindingSource.DataSource = orderList;
                    txtQuantity.Text = 1.ToString();

                }
                txtTotal.Text = orderList.Sum(o => o.Price * o.Quantity).ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var db = new BmomMarketContext();
            Order order = new Order()
            {
                OrderDate = DateTime.Now,
                CustomerId = (cbbCustomer.SelectedItem as Customer).CustomerId,
                EmployeeId = user.EmployeeId,
                TotalPrice = long.Parse(txtTotal.Text),
            };
            db.Orders.Add(order);
            db.SaveChanges();
            var orderId = db.Orders.Max(o => o.OrderId);

            foreach (var item in orderList)
            {
                OrderDetail newOrder = new OrderDetail()
                {
                    ProductId = item.ProductID,
                    OrderId = orderId,
                    Quantity = item.Quantity,

                };
                db.OrderDetails.Add(newOrder);
            }
            db.SaveChanges();
            orderDetailDTOBindingSource.DataSource = null;
            orderList.Clear();
            MessageBox.Show("Tạo hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getOrderID();
            LoadProductListByCategoryID(0);
        }

        private void tblBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
            {
                return;
            }
            row = tblBill.Rows[e.RowIndex];
            OrderDetailDTO product = (OrderDetailDTO)row.DataBoundItem;
            txtQuantity.Text = product.Quantity.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var db = new BmomMarketContext();
            var selProduct = orderDetailDTOBindingSource.Current as OrderDetailDTO;
            OrderDetailDTO updateProduct = orderList.Where(t => t.ProductID == selProduct.ProductID).FirstOrDefault();

            if (updateProduct == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long idUpdate = updateProduct.ProductID;

            var productInStock = db.Products.Where(p => p.ProductId == idUpdate).FirstOrDefault();
            long quantityInStock = (long)productInStock.Quantity;


            if (quantityInStock < long.Parse(txtQuantity.Text.Trim()))
            {
                MessageBox.Show("Không đủ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                updateProduct.Quantity = long.Parse(txtQuantity.Text.Trim());
                updateProduct.TotalPrice = updateProduct.Price * updateProduct.Quantity;
                orderDetailDTOBindingSource.DataSource = null;
                orderDetailDTOBindingSource.DataSource = orderList;
                txtQuantity.Text = "1";
                txtTotal.Text = orderList.Sum(o => o.Price * o.Quantity).ToString();
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower().Trim();
            var db = new BmomMarketContext();
            var ls = db.Products.Where(p => p.ProductName.ToLower().Trim().Contains(searchText)).Select(e => new ProductDTO
            {
                ProductId = e.ProductId,
                ProductName = e.ProductName,
                Price = e.Price,
                Image = e.Image,
            }).ToList();
            renderProduct(ls);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selProduct = orderDetailDTOBindingSource.Current as OrderDetailDTO;
            OrderDetailDTO newProduct = orderList.Where(t => t.ProductID == selProduct.ProductID).FirstOrDefault();

            if (newProduct == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            orderList.Remove(newProduct);
            orderDetailDTOBindingSource.DataSource = null;
            orderDetailDTOBindingSource.DataSource = orderList;
            txtTotal.Text = orderList.Sum(o => o.Price * o.Quantity).ToString();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Category selected = cb.SelectedItem as Category;
            long idcategory = selected.CategoryId;
            LoadProductListByCategoryID(idcategory);
        }
        void LoadProductListByCategoryID(long idcategory = 0)
        {
            var db = new BmomMarketContext();
            List<ProductDTO> ls;
            if (idcategory == 0)
            {
                ls = db.Products.Select(c => new ProductDTO
                {
                    ProductId = c.ProductId,
                    ProductName = c.ProductName,
                    Price = c.Price,
                    Image = c.Image,
                    Quantity = c.Quantity,
                }).ToList();
            }
            else
            {
                ls = db.Products.Where(c => c.CategoryId == idcategory)
                    .Select(c => new ProductDTO
                    {
                        ProductId = c.ProductId,
                        ProductName = c.ProductName,
                        Price = c.Price,
                        Image = c.Image,
                        Quantity = c.Quantity,
                    }).ToList();
            }
            renderProduct(ls);
        }

        private void btnFormCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer f = new FormCustomer();
            f.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadCustomer();
        }
    }
}
