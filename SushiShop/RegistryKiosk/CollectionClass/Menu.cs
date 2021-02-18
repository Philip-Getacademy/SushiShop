using SushiShop.Food;

using System;
using System.Collections.Generic;
using System.Text;

namespace SushiShop.RegistryKiosk
{
    class Menu
    {
        private Recipes Recipes { get; set; }
        private Categories Categories { get; set; }


        public Menu()
        {
            Recipes = new Recipes();
            Categories = new Categories();
        }
    }
}
