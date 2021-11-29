using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.DataAccess
{
    using Database;
    using Entities;
    public class OrderRepo
    {

        public string Add(Cart cart)
        {
            string result;
            if (FindByID(cart.OrderID)==null)
            {
                DBAllOrders.OrdersDatabase.Add(cart);
                result = "Sipariş Başarıyla Oluşuturuldu.";
            }
            else
            {
                result = "Sipariş Oluşturulamadı";
            }
            return result;

        }
        public string Update(Cart cart)
        {
            string result;
            if (FindByID(cart.OrderID)!=null)
            {
                var alias = DBAllOrders.OrdersDatabase.FirstOrDefault(item => item.OrderID == cart.OrderID);
                alias.OrderID = cart.OrderID; //order ID değişmediğinden emin olmak için yaptım.
                DBAllOrders.OrdersDatabase.RemoveAll(item => item.OrderID == alias.OrderID);
                result = Add(cart);
            }
            else
            {
                result = "Güncelleme yapılamadı";
            }
            return result;
            

        }

        public string Delete(Cart cart)
        {
            string result;
            if (FindByID(cart.OrderID) == null)
            {
                result = "Silinecek veri bulunamadı";

            }
            else
            {
                DBAllOrders.OrdersDatabase.RemoveAll(item => item.OrderID == cart.OrderID);
                result = "Silme İşlemi Başarılı";
            }
            return result;
        }
        public string DeleteByID(string  cartID)
        {
            string result;
            if (FindByID(cartID) == null)
            {
                result = "Silinecek veri bulunamadı";

            }
            else
            {
                DBAllOrders.OrdersDatabase.RemoveAll(item => item.OrderID == cartID);
                result = "Silme İşlemi Başarılı";
            }
            return result;
        }
        public List<Cart> GetCarts()
        {
            return DBAllOrders.OrdersDatabase;

        }

        public Cart FindByID(string ID)
        {
            return DBAllOrders.OrdersDatabase.FirstOrDefault(item=>item.OrderID == ID);
        } 

    }
}
