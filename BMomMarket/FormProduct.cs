using BMomMarket.DTO;
using BMomMarket.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMomMarket
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            loadProduct();
            loadCategory();
        }

        void loadProduct()
        {
            var db = new BmomMarketContext();
            var ls = db.Products.Select(e => new ProductDTO
            {
                ProductId = e.ProductId,
                ProductName = e.ProductName,
                Description = e.Description,
                Price = e.Price,
                Quantity = e.Quantity,
                Image = e.Image,
            }).ToList();
            productDTOBindingSource.DataSource = ls;
        }
        int checkInput()
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(rtbDescription.Text))
            {
                return 1;
            }
            return 0;
        }
        void ResetInput()
        {
            txtProductName.Text = "";
            rtbDescription.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            picProduct.ImageLocation = null;
        }

        void loadCategory()
        {
            var db = new BmomMarketContext();
            var ls = db.Categories.Select(e => new CategoryDTO
            {
                CategoryId = e.CategoryId,
                CategoryName = e.CategoryName,
            }).ToList();
            cbbCategory.DataSource = ls;
            cbbCategory.DisplayMember = "CategoryName";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
            {
                return;
            }
            row = dataGridView1.Rows[e.RowIndex];
            ProductDTO product = (ProductDTO)row.DataBoundItem;
            txtProductName.Text = product.ProductName;
            rtbDescription.Text = product.Description;
            txtPrice.Text = product.Price.ToString();
            txtQuantity.Text = product.Quantity.ToString();
            if (!string.IsNullOrEmpty(product.Image))
                picProduct.ImageLocation = product.Image;
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
                Product newProduct = new Product
                {
                    ProductName = txtProductName.Text,
                    Description = rtbDescription.Text,
                    Price = long.Parse(txtPrice.Text),
                    Quantity = long.Parse(txtQuantity.Text),
                    Image = picProduct.ImageLocation,
                    CategoryId = (cbbCategory.SelectedItem as CategoryDTO).CategoryId,
                };
                db.Add(newProduct);
                db.SaveChanges();
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetInput();
                loadProduct();
            }
        }


        private void picProduct_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Title = "Chọn ảnh",
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var selectedFile = openFile.FileName;
                picProduct.ImageLocation = selectedFile;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selProduct = productDTOBindingSource.Current as ProductDTO;
            if (selProduct != null)
            {
                var rs = MessageBox.Show("Đồng ý xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new BmomMarketContext();
                    var obj = db.Products.Where(t => t.ProductId == selProduct.ProductId).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Remove(obj);
                        db.SaveChanges();
                        loadProduct();
                        MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var selProduct = productDTOBindingSource.Current as ProductDTO;
                Product newProduct = db.Products.Where(t => t.ProductId == selProduct.ProductId).FirstOrDefault();

                if (newProduct == null)
                {
                    MessageBox.Show("Sản phẩm không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                newProduct.ProductName = txtProductName.Text;
                newProduct.Description = rtbDescription.Text;
                newProduct.Price = long.Parse(txtPrice.Text);
                newProduct.Quantity = long.Parse(txtQuantity.Text);
                newProduct.Image = picProduct.ImageLocation;

                db.SaveChanges();
                loadProduct();
                MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetInput();
            }
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            long CategoryID = (cbbCategory.SelectedItem as CategoryDTO).CategoryId;
            var db = new BmomMarketContext();
            var ls = db.Products.Where(e => e.CategoryId == CategoryID)
                .Select(e => new ProductDTO
                {
                    ProductId = e.ProductId,
                    ProductName = e.ProductName,
                    Description = e.Description,
                    Price = e.Price,
                    Quantity = e.Quantity,
                    Image = e.Image,
                }).ToList();
            productDTOBindingSource.DataSource = ls;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void btnResetInput_Click(object sender, EventArgs e)
        {
            ResetInput();
        }
    }
}
