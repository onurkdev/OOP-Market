using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Entities
{
    
    public class Cart
    {
        public List<Product> Products { get; set; }
        public string OrderID { get; set; }

        public double TotalSum { get; set; }

        public int ItemQuantity { get; set; }

        public Cart(List<Product> products)
        {
            Products=products;
            double totalprice = 0;
            int totalqty = 0;
            foreach(var product in products)
            {
                totalqty += product.Quantity;
                totalprice += product.ProductTotalPrice;
            }
            TotalSum = totalprice;
            ItemQuantity=totalqty;
            Guid guid = Guid.NewGuid();
            OrderID = guid.ToString();
        }

        public override string ToString()
        {
            return $"Siparişiniz Oluşturuldu: \nToplam Ürün Sayısı {this.ItemQuantity} \nToplam Tutar: {this.TotalSum}\nTakip No:{OrderID}";

        }
    }
}
