using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Entities
{
    public class Product
    {
        public int ListIndex { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
        public double ProductTotalPrice { get; set; }

        public Product(int productID , string productName, double productPrice)
        {
            ProductID = productID;
            ProductName = productName;
            ProductPrice = productPrice;
            ListIndex = -1;
            
        }
        public void AddIndex(int index)
        {
            this.ListIndex = index;
        }
        public override string ToString()
        {
            return $"{ProductName} - {String.Format("{0:0.##}", this.ProductPrice)} - TL";
        }

        public string AllToString()
        {
            return $"{Quantity} adet {ProductName} - {String.Format("{0:0.##}", this.ProductTotalPrice)} - TL";
        }
        public void CalculatePrice()
        {
            this.ProductTotalPrice = this.ProductPrice * this.Quantity;
        }
    }
}
