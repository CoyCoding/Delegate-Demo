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
        public DelegateDemoUI()
        {
            InitializeComponent();

        }
        public static void SubTotalAlert(decimal subTotal)
        {

        }

        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
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
    }
}
