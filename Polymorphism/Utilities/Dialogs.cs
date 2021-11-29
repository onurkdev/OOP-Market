using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism.Utilities
{
    public class Dialogs
    {
        string deletequestionmessage = "Silmek istediğinize emin misiniz?";
        string deletesuccess = "Silme işlemi başarılı";
        string deleteerror = "Silme işlemi başarısız oldu";
        string addproductsuccess = "Ürün Başarıyla sepete eklendi";
        string addcartsuccess = "Siparişiniz başarıyla alındı";
        string addproducterror = "Ürün sepete eklenemedi";
        string addcarterror = "Siparişinizi alırken bir problem oluştu";
        string updateproductsuccess = "Ürün başarıyla güncellendi";
        string updatecartsuccess = "Sepet başarıyla Güncellendi";
        string updateproducterror = "Ürün güncelleme Başarısız";
        string updatecarterror = "Sepet Güncelleme başarısız";
        string defaulterror = "Bir problemle karşılaştık";

        public bool AskDelete()
        {
            bool response;
            var result = MessageBox.Show(deletequestionmessage);
            if (result == DialogResult.OK)
                response = true;
            else
                response = false;
            return response;

        }

        //hızlı olmak için messagebox şekillendirmeye girmedim
        public void DeleteSuccess()
        {
            MessageBox.Show(deletesuccess);
        }

        public void DeleteError()
        {
            MessageBox.Show(deleteerror);

        }
        public void AddProductSuccess()
        {
            MessageBox.Show(addproductsuccess);
        }
        public void AddProductError()
        {
            MessageBox.Show(addproducterror);
        }
        public void AddCartSuccess()
        {
            MessageBox.Show(addcartsuccess);
        }
        public void AddCartError()
        {
            MessageBox.Show(addcarterror);
        }
        public void UpdateProductError()
        {
            MessageBox.Show(updateproducterror);
        }
        public void UpdateProductSuccess()
        {
            MessageBox.Show(updateproductsuccess);
        }
        public void UpdateCartSucess()
        {
            MessageBox.Show(updatecartsuccess);
        }
        public void UpdateCartError()
        {
            MessageBox.Show(updatecarterror);
        }
        public void DefaultError()
        {
            MessageBox.Show(defaulterror);
        }
    }
}
