using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Database
{
    using Entities;
    public class DBAllOrders
    {
        public static List<Cart> OrdersDatabase = new List<Cart>();
        public static List<Product> CartDatabase = new List<Product>();


        public static Product[] DummyProducts ;    

        public static void FillProducts()
        {
            Product gofret = new Product(0, "Ülker Gofret", 2.50);
            Product cikolata = new Product(1, "Ülker Baton Çikolata", 4.50);
            Product biskuvi = new Product(2, "Burçak", 3.50);
            Product kekstra = new Product(3, "Kekstra", 1.25);
            Product peki = new Product(4, "Peki", 1.00);
            Product hanimeller = new Product(5, "Hanımeller", 3.50);
            Product magnum = new Product(6, "Magnum", 8.50);
            Product cornetto = new Product(7, "Cornetto", 5.50);

            DummyProducts = new[] { gofret, cikolata, biskuvi, kekstra, peki, hanimeller, magnum, cornetto };

        }
    }
}
