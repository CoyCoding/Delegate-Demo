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
            Items = new List<ProductModel>(); 
        }

        public List<ProductModel> Items{ get; set; }

        //Delegated generate Total
        //Nomally I would not have three delegates like this. 

        public decimal GenerateTotal(
            MentionPreTotal mentionPreTotal, 
            Func<List<ProductModel>, decimal, decimal> calculateDiscountedTotal, 
            Action<string> mentionDiscount)
        {   
            //preTotal = Sum of all item prices in the cart
            decimal preTotal = Items.Sum(items => items.Price);

            mentionPreTotal(preTotal);

            mentionDiscount("(The Action Delegate) After applying your discount:");

            return calculateDiscountedTotal(Items, preTotal);

        }
    }
}
