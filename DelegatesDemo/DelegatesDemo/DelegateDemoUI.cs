using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DelegateDemoLibrary;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesDemo
{
    public partial class DelegateDemoUI : Form
    {
        static ShoppingCartModel cart = new ShoppingCartModel();

        public DelegateDemoUI()
        {
            InitializeComponent();
            SetUpCart();
            

        }

        private static void PreTotalAlert(decimal preTotal)
        {
            MessageBox.Show($"The subtotal is {preTotal:C2}");
        }

        private static void AlertUser(string message)
        {
            MessageBox.Show(message);
        }
        
        private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal preTotal)
        {
            //20% off for orders over $100
            if (preTotal > 100)
            {
                return preTotal * 0.80M;
            }
            //15% off for orders over $50
            else if (preTotal > 50)
            {
                return preTotal * 0.85M;
            }
            //10% off for orders over $10
            else if (preTotal > 10)
            {
                return preTotal * 0.95M;
            }
            else
            {
                return preTotal;
            }
        }

        private static void SetUpCart()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Doritos", Price = 2.50M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 1.30M });
            cart.Items.Add(new ProductModel { ItemName = "Eggs", Price = 1.23M });
            cart.Items.Add(new ProductModel { ItemName = "TV", Price = 500.00M });
        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void TotalTextBoxBtn_Click(object sender, EventArgs e)
        {

            //I don't know how to do this without the total variable;  :(

            //TotalTextBox.Text = cart.GenerateTotal(
            //    (preTotal) => PreTotalTextBox.Text = $"{preTotal:C2}",
            //    (items, preTotal) => preTotal - (items.Count * 2),
            //    (x) => { }).ToString();

  
            decimal total = cart.GenerateTotal(
               (preTotal) => PreTotalTextBox.Text = $"{preTotal:C2}",
               (items, preTotal) => preTotal - (items.Count * 2),
               (x) => { });

            TotalTextBox.Text = $"{total:C2}";
        }

        private void TotalAlertBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"(Different Total logic?!? a.k.a. Third Delegate) The total after this weeks sale is: " +
                $"{cart.GenerateTotal(PreTotalAlert, CalculateLeveledDiscount, AlertUser):C2}");
        }
    }
}
