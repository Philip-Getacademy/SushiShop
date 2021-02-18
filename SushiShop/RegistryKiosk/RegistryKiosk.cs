
using System;
using System.Collections.Generic;
using System.Linq;
using SushiShop.Economy;
using SushiShop.Food;
using SushiShop.Misc;

namespace SushiShop.RegistryKiosk
{
    class Kiosk
    {

        public Ingredients Ingredients { get; set; }
        public Recipes Recipes { get; set; }
        public List<Receipt> OrderHistory { get; set; }

        public Categories C { get; set; }

        public Kiosk()
        {
            Ingredients = new Ingredients();
            Recipes = new Recipes();
            OrderHistory = new List<Receipt>();

            C = new Categories();
        }

        // Execute Kiosk Logic
        public void Run()
        {
            foreach (var c in C.Cs)
            {
                Console.WriteLine(c.SName);
            }
        }

        //public void OrderItem(string item, int amount)
        //{
        //    var receipt = new Receipt(FetchSelectedIngredientsList(item), amount); 
        //    OrderHistory.Add(receipt);
        //    Console.WriteLine(receipt.GenerateReceipt());

        //}

        //public string FetchRecipeName(string item) =>
        //    Recipes.GetRecipeList.Find(x => x.Name == item)?.Name;

        //public List<KeyValuePair<Ingredient, Amount>> FetchSelectedIngredientsList(string item) =>
        //    Recipes.GetRecipeList.Find(x => x.Name == item)?.Items.ToList();

    }
}
