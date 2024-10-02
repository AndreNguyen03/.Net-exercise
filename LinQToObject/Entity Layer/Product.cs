using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQToObject.Data_Layer
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductValue { get; set; }
        public string ProductOrigin { get; set; }
        public DateTime ProductExpired { get; set; }

        public Product(int productId, string name, int quantity, double price, string origin, DateTime expirydate)
        {
            ProductID = productId;
            ProductName = name;
            ProductQuantity = quantity;
            ProductValue = price;
            ProductOrigin = origin;
            ProductExpired = expirydate;
        }
    }
}
