using LinQToObject.Business_Layer;
using LinQToObject.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQToObject
{
    public partial class Form1 : Form
    {
        private readonly ProductBL _productBL;
        private readonly ProductDAL _productDAL;
        private List<Product> searchData = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            _productDAL = new ProductDAL();
            _productBL = new ProductBL(_productDAL);
            LoadProductsToGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product(
                int.Parse(tbProductId.Text),
                tbProductName.Text,
                int.Parse(tbQuantity.Text),
                double.Parse(tbValue.Text),
                tbOrigin.Text,
                dateTime.Value
            );

            _productBL.AddProduct(newProduct);
            tbProductId.Text = string.Empty;
            tbProductName.Text = string.Empty;
            tbQuantity.Text = string.Empty;
            tbValue.Text = string.Empty;
            tbOrigin.Text = string.Empty;
     
            LoadProductsToGrid();
        }

       

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            _productBL.DeleteProduct(int.Parse(tbProductId.Text));
            LoadProductsToGrid();
        }



        private void btnMostValue_Click(object sender, EventArgs e)
        {
            Product expensive = _productBL.FindMostExpensiveProduct();
            searchData.Clear();
            searchData.Add(expensive);

            LoadProductsToSearchGrid();
        }

        private void btnFromJP_Click(object sender, EventArgs e)
        {
            Product fromJP = _productBL.FindProductFromJapan();
            searchData.Clear();
            searchData.Add(fromJP);

            LoadProductsToSearchGrid();
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            searchData.Clear();
            List<Product> products = _productBL.GetExpiredProducts();

            foreach(Product product in products)
            {
                searchData.Add(product);
            }
            LoadProductsToSearchGrid();
        }

        private void btnFromTo_Click(object sender, EventArgs e)
        {
            searchData.Clear();
            List<Product> productsFromTo = _productBL.GetProductsByPriceRange(double.Parse(tbFrom.Text),double.Parse(tbTo.Text));

            foreach(Product product in productsFromTo)
            {
                searchData.Add(product);
            }
            LoadProductsToSearchGrid();
        }

        private void btnDeleteOrigin_Click(object sender, EventArgs e)
        {
            _productBL.RemoveAllProductsByOrigin(tbDeleteOrigin.Text);
            LoadProductsToGrid();
        }

        private void btnCheckExpired_Click(object sender, EventArgs e)
        {
            if(_productBL.IsAnyProductExpired())
            {
                MessageBox.Show("Có sản phẩm quá hạn!");
            } else
            {
                MessageBox.Show("Không có sản phẩm quá hạn!");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            _productBL.RemoveAllProducts();
            LoadProductsToGrid();
        }

        private void btnDeleteAllExpired_Click(object sender, EventArgs e)
        {
            _productBL.DeleteExpiredProducts();
            LoadProductsToGrid();
        }

        private void LoadProductsToGrid()
        {
            dgvData.DataSource = _productBL.GetAllProducts();
        }

        private void LoadProductsToSearchGrid()
        {
            dgvData.DataSource = searchData;
        }

        
    }
}
