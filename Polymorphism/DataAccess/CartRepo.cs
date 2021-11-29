using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.DataAccess
{
    using Entities;
    using Database;
    public class CartRepo
    {
        
        //return string verip success response gibi davranmasını sağladım.
        public string Add(Product product)
        {
            string result;
            if (FindbyID(product.ProductID) == null)
            {
                DBAllOrders.CartDatabase.Add(product);
                result = "Ürün Sepete Başarıyla Eklendi";
            }
            else
            {
                result=Update(product);
            }
            return result;
        }
        public Product FindByListIndex(int index)
        {
            return DBAllOrders.CartDatabase.FirstOrDefault<Product>(item=> item.ListIndex == index);
        }
        public Product FindbyID(int ID)
        {
            return DBAllOrders.CartDatabase.FirstOrDefault<Product>(item => item.ProductID == ID);
        }

        public string Update(Product product)
        {
            string result;
            Product response = FindbyID(product.ProductID);
            if (response != null)
            {

                Remove(response);
                DBAllOrders.CartDatabase.Add(product);
                result = "Ürün Başarıyla güncellendi";

            }
            else
            {
                result = "Veritabanına ulaşamadık!";
            }
            return result;

        }

        public List<Product> GetProducts()
        {
            return DBAllOrders.CartDatabase;
        }

        public string Remove(Product product)
        {
            DBAllOrders.CartDatabase.RemoveAll(item => item.ProductID == product.ProductID);
            return "Ürün başarıyla kaldırıldı.";
        }


    }
}
