using System;
using SushiShop.Misc;

using System.Collections.Generic;

namespace SushiShop.Food
{
    class Ingredients
    {
        public List<Ingredient> I { get; }

        public Ingredient Rice => GetIngredient("Rice");
        public Ingredient Salmon => GetIngredient("Salmon");
        public Ingredient Scallop => GetIngredient("Scallop");

        private readonly List<Ingredient> DBIs;

        public Ingredients()
        {
            DBIs = new List<Ingredient>();
            CollectIngredientsFromDB();

            I = DBIs;

            // Console.WriteLine(I[3].Name.ThisName);
        }

        public void ListCurrentStock()
        {
            Console.WriteLine("Items in stock :");
            foreach (var ingredient in I)
            {
                Console.WriteLine(
                    ingredient.Id.GetID() + " - " +
                    ingredient.Name + " - " +
                    ingredient.Price + " - " +
                    ingredient.Amount
                );
            }
        }

        private Ingredient GetIngredient(string s) => I.Find(x => x.Name == s);

        // XML??
        private void CollectIngredientsFromDB()
        {
            DBIs.Add(new Ingredient("Rice", 5, 100, "Rice"));
            DBIs.Add(new Ingredient("Carrot", 5, 10, "Vegetable"));
            DBIs.Add(new Ingredient("Black Bean", 10, 10, "Vegetable"));
            DBIs.Add(new Ingredient("Salmon", 20, 10, "Meat"));
            DBIs.Add(new Ingredient("Scallop", 40, 10, "Meat"));
            DBIs.Add(new Ingredient("Vanilla", 15, 10, "Ice Cream"));
            DBIs.Add(new Ingredient("Choclate", 15, 10, "Ice Cream"));
        }

    }
}
