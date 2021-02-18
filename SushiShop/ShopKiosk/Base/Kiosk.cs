
using System.Collections.Generic;
using SushiShop.Economy;
using SushiShop.Food;
using SushiShop.Misc;

namespace SushiShop.ShopKiosk
{
    // This is one store not a franchise
    abstract class Kiosk
    {
        private Name N { get; set; }

        // Economy
        internal List<Receipt> ListR { get;  }
        internal List<Order> ListO { get;  }

        // Storage ? static
        internal Storage S { get; }

        // Food Stuffs
        internal Recipes Rs { get; set; }

        // Ingredient Categories
        internal Categories Cs { get; set; }

        protected Kiosk(string name)
        {
            S = new Storage();
            Rs = new Recipes();
            N = new Name(name);
            Cs = new Categories();

            ListO = new List<Order>();
            ListR = new List<Receipt>();
        }

        protected string KioskName => N.SName;

        public abstract void Order(params string[] selectedItems);
    }
}



