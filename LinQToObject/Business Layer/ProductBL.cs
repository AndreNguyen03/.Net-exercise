using LinQToObject.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQToObject.Business_Layer
{
    public class ProductBL
    {
        private ProductDAL _productDAL;

        public ProductBL(ProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void AddProduct(Product product)
        {
            _productDAL.AddProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return _productDAL.UpdateProduct(product);
        }

        public bool DeleteProduct(int productId)
        {
            return _productDAL.DeleteProduct(productId);
        }

        public bool IsAnyProductExpired()
        {
            return _productDAL.GetAllProducts().Exists(p => p.ProductExpired < DateTime.Now);
        }

        public Product FindMostExpensiveProduct()
        {
            return _productDAL.GetAllProducts().OrderByDescending(p => p.ProductValue).FirstOrDefault();
        }

        public Product FindProductFromJapan()
        {
            return _productDAL.GetAllProducts().Find(p => p.ProductOrigin == "Nhật Bản");
        }

        public List<Product> GetExpiredProducts()
        {
            return _productDAL.GetAllProducts().FindAll(p => p.ProductExpired < DateTime.Now);
        }

        public List<Product> GetProductsByPriceRange(double a, double b)
        {
            return _productDAL.GetAllProducts().FindAll(p => p.ProductValue >= a && p.ProductValue <= b);
        }

        public int RemoveAllProductsByOrigin(string origin)
        {
            return _productDAL.GetAllProducts().RemoveAll(p => p.ProductOrigin == origin);
        }

        public void RemoveAllProducts()
        {
            _productDAL.DeleteAllProducts();
        }

        public List<Product> GetAllProducts()
        {
            return _productDAL.GetAllProducts();
        }

        public void DeleteExpiredProducts()
        {
            _productDAL.DeleteExpiredProducts();
        }
    }

}
