
using System.Collections.Generic;
using System.Linq;
using SushiShop.Food;
using SushiShop.Misc.DescribingClass;
using SushiShop.Misc;
using System;
using SushiShop.Economy;

namespace SushiShop
{
    class Storage
    {
        private static DBTableConstructorFile DBI;
        public List<Ingredient> ListI { get; private set; }


        // CTOR
        public Storage() { ListI = CollectIngredientsStatusFromDB(); }
        public Storage(Ingredient[] ingredients) { ListI = PopulateStorage(ingredients); }
        public Storage(List<Ingredient> ingredients) { ListI = PopulateStorage(ingredients); }

        internal bool HasIngredients(Recipe recipe)
        {
            foreach (var (i, a) in recipe.Items)
            {
                if (!ListI.Any(x => x.Name == i.Name && x.Amount >= a.Count)) return false;
            }

            return true;
        }


        public void UpdateStorage(List<Ingredient> orders)
        {
            foreach (var i in orders)
                ListI
                    .Find(j => j.Name == i.Name)?
                    .Decrement(i.Amount);
        }

        //public void UpdateStorage(List<Recipe> orders)
        //{
        //    foreach (var r in orders)
        //        foreach (var (i, a) in r.DictIA)
        //            ListI
        //                .Find(I => I.Name == i.Name)?
        //                .Decrement(a.Count);
        //}
        
        public void OrderStorage(Ingredient i, int a)
        {
            ListI
                    .Find(I => I.Name == i.Name)?
                    .Increment(a);
        }


        public bool HasIngredients(List<Ingredient> total)
        {
            
            foreach (var i in ListI)
                foreach (var j in total)
                {
                    if (!HasIngredients(i.Name, j.Amount)) return false;
                }

            return true;
        }


        private bool HasIngredients(string itemName, int amount) => ListI.Any(x => x.Name.ToLower() == itemName.ToLower() && x.Amount >= amount);

        public override string ToString()
        {
            return ListI
                .Aggregate("", (seed, p) => 
                    $"{seed}Item : {p.Name} - {p.Amount} \n"
                    
                    );
        }

        public List<Ingredient> PopulateStorage(List<Ingredient> items) => items;
        public List<Ingredient> PopulateStorage(Ingredient[] items) => items.ToList();

        // Transfer
        private static List<Ingredient> CollectIngredientsStatusFromDB()
        {
            var DBI = new List<Ingredient>();

            DBI.Add(new Ingredient("Rice", 5, 100, "Rice"));
            DBI.Add(new Ingredient("Carrot", 5, 10, "Vegetable"));
            DBI.Add(new Ingredient("Black Bean", 10, 10, "Vegetable"));
            DBI.Add(new Ingredient("Salmon", 20, 10, "Meat"));
            DBI.Add(new Ingredient("Scallop", 40, 10, "Meat"));
            DBI.Add(new Ingredient("Vanilla", 15, 10, "Ice Cream"));
            DBI.Add(new Ingredient("Choclate", 15, 10, "Ice Cream"));

            return DBI;
        }
    }
}
