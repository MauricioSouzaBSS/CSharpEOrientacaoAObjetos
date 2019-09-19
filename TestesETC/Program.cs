using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesETC
{
    class Program
    {
        public string cookieRecipe;
        private string secretIngredient;
        private const int loyalCustomerOrderAmount = 60;
        public int Temperature;
        private string ingredientSupplier;

        public string GetRecipe(int orderAmount)
        {

            if (orderAmount >= loyalCustomerOrderAmount)
            {
                return cookieRecipe + " " + secretIngredient;
            }
            else
            {
                return cookieRecipe;
            }
        }

            


        static void Main(string[] args)
        {

            

        }
    }
}
