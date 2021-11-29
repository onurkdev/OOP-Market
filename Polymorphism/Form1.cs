using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polymorphism.Database;
using Polymorphism.Entities;
using Polymorphism.DataAccess;
using Polymorphism.Utilities;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        
        Dialogs dialogs =new Dialogs();
        OrderRepo orderRepo = new OrderRepo();
        CartRepo cartRepo = new CartRepo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillData();
        }

        public void ClearForm()
        {
            
            lstOrders.Items.Clear();
            lblUrun.Text = "Ürün Sayısı:";
            lblSum.Text = "Toplam: - TL";
            ClearAdd();
        }
        public void ClearAdd()
        {
            cmbProduct.SelectedIndex = -1;
            nudQty.Value = 0;
        }



        public void FillData()
        {
            DBAllOrders.FillProducts();
            cmbProduct.Items.AddRange(DBAllOrders.DummyProducts);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product selectedProduct;

            if ( cartRepo.FindbyID(cmbProduct.SelectedIndex) == null)
            {
                selectedProduct = cmbProduct.SelectedItem as Product;
            }else
            {
                selectedProduct = cartRepo.FindbyID(cmbProduct.SelectedIndex);
            }


            if (selectedProduct != null)
            {
                selectedProduct.Quantity += Convert.ToInt32(nudQty.Value);
                selectedProduct.CalculatePrice();
                if (selectedProduct.ListIndex != -1)
                {

                    lstOrders.Items.RemoveAt(selectedProduct.ListIndex);
                    lstOrders.Items.Insert(selectedProduct.ListIndex, selectedProduct.AllToString());
                }
                else
                {
                    lstOrders.Items.Add(selectedProduct.AllToString());
                    selectedProduct.AddIndex(lstOrders.Items.Count - 1);
                }

                
                cartRepo.Add(selectedProduct);
                UpdateCartSum();
                ClearAdd();

            }


        }

        private void lstOrders_DoubleClick(object sender, EventArgs e)
        {
            btnProductDelete.Enabled = true;
            btnUpdate.Enabled =true;
            btnAdd.Enabled =false;
            int index = lstOrders.SelectedIndex;
            Product selectedproduct = cartRepo.FindByListIndex(index);
            if (selectedproduct != null)
            {
                SetProduct(selectedproduct);
                cmbProduct.Enabled = false;
            }
            else
            {
                dialogs.DefaultError();
            }

        }

        public void SetProduct (Product product)
        {
            if (product != null)
            {
                cmbProduct.SelectedIndex = product.ProductID;
                nudQty.Value = product.Quantity;
            }
            else
            {
                dialogs.DefaultError();
            }
        }

        private void UpdateCartSum()
        {
            int count=0;
            double total=0;
            string labelqty;
            string labelprice;
            List<Product> products = cartRepo.GetProducts();
            foreach (Product product in products)
            {
                count += product.Quantity;
                total += product.ProductTotalPrice;
            }
            labelqty = $"Ürün Sayısı: {count} adet ürün";
            labelprice = $"Toplam: {total} - TL";
            lblUrun.Text = labelqty;
            lblSum.Text = labelprice;

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            bool response = dialogs.AskDelete();
            if (response)
            {
                
                try
                {
                    Product selectedproduct = cmbProduct.SelectedItem as Product;

                    lstOrders.Items.RemoveAt(selectedproduct.ListIndex);
                    cartRepo.Remove(selectedproduct);
                    dialogs.DeleteSuccess();
                }
                catch (Exception)
                {
                    //ex i bilerek kullanmadım basitleştirmek için
                    dialogs.DeleteError();
                }
                ClearAdd();
                UpdateCartSum();
            }
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product selectedProduct;
            selectedProduct = cartRepo.FindbyID(cmbProduct.SelectedIndex);


            if (selectedProduct != null)
            {
                selectedProduct.Quantity = Convert.ToInt32(nudQty.Value);
                selectedProduct.CalculatePrice();
                lstOrders.Items.RemoveAt(selectedProduct.ListIndex);
                lstOrders.Items.Insert(selectedProduct.ListIndex, selectedProduct.AllToString());
                cartRepo.Add(selectedProduct);
                UpdateCartSum();


            }
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            cmbProduct.Enabled = true;
            btnProductDelete.Enabled = false;
            ClearAdd();

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {


            Cart cart = new Cart(cartRepo.GetProducts());
            orderRepo.Add(cart);
            
            grdOrders.DataSource = null;
            grdOrders.DataSource = orderRepo.GetCarts();
            GridSizer();
            ClearForm();
            dialogs.AddCartSuccess();

        }
        private void GridSizer()
        {
            grdOrders.Columns[0].HeaderText = "Sipariş Kodu";
            grdOrders.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grdOrders.Columns[1].HeaderText = "Ürün Miktarı";
            grdOrders.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grdOrders.Columns[2].HeaderText = "Sipariş toplamı";
            grdOrders.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
