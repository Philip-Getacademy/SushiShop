
using System;
using System.Collections.Generic;
using System.Linq;
using SushiShop.Economy;
using SushiShop.Food;
using SushiShop.Misc;
using SushiShop.RegistryKiosk.CollectionClass;

namespace SushiShop.ShopKiosk
{
    internal class AutomatedKiosk : Kiosk
    {

        public AutomatedKiosk(string name) : base(name) { }

        // Execute Kiosk Logic
        public void Run()
        {

            Console.WriteLine($"Welcome to {KioskName}");

        }

        // "Scallop Nigiri", "Salmon Nigiri", "Salmon Nigiri"
        public override void Order(params string[] items)
        {
            var RequestedRecipes = Rs.FetchRecipes(items);
            var InvalidRecipes = RequestedRecipes.Length != items.Length;

            if (InvalidRecipes)
            {
                KioskMessages.ErrorMessage(KioskMessages.InvalidRecipeItem);
                return;
            }

            Console.WriteLine(S);

            var IngredientsDemand = Recipe.Combine(RequestedRecipes);
            if(S.HasIngredients(IngredientsDemand))
                S.UpdateStorage(IngredientsDemand);

            Console.WriteLine(S);
        }
    }
}



