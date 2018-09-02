using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionPreTotal(decimal preTotal);

        public ShoppingCartModel()
        {
            Cart = new List<ProductModel>(); 
        }

        public List<ProductModel> Cart{ get; set; }

        //Delegated generate Total
        //Nomally I would not have three delegates like this. 

        public decimal GenerateTotal(MentionPreTotal mentionPreTotal, Func<List<ProductModel>, decimal, decimal>
            calculateDiscountedTotal, Action<string> mentionDiscount)
        {   
            //preTotal = Sum of all item prices in the cart
            decimal preTotal = Cart.Sum(items => items.Price);

            mentionPreTotal(preTotal);

            mentionDiscount("After applying your discount:");

            return calculateDiscountedTotal(Cart, preTotal);

        }
    }
}
