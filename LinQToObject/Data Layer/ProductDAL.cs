using LinQToObject.Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQToObject.Data_Layer
{
    public class ProductDAL
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public bool UpdateProduct(Product product)
        {
            var existingProduct = _products.Find(p => p.ProductID == product.ProductID);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.ProductQuantity = product.ProductQuantity;
                existingProduct.ProductValue = product.ProductValue;
                existingProduct.ProductOrigin = product.ProductOrigin;
                existingProduct.ProductExpired = product.ProductExpired;
                return true;
            }
            return false;
        }

        public bool DeleteProduct(int productId)
        {
            var product = _products.Find(p => p.ProductID == productId);
            return _products.Remove(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public void DeleteAllProducts()
        {
            _products.Clear();
        }

        public void DeleteExpiredProducts()
        {
            _products.RemoveAll(p => p.ProductExpired < DateTime.Now);
        }
    }

}
