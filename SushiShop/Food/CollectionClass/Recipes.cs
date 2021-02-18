using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SushiShop.Food
{
    class Recipes
    {
        internal readonly List<Recipe> ListR;
        private Ingredients I { get; }

        public Recipes()
        {
            I = new Ingredients();
            ListR = new List<Recipe>();
            RecepieBuilder();
        }


        private void RecepieBuilder()
        {
            ListR.Add(new Recipe("Salmon Nigiri", "Nigiri", I.Rice, I.Salmon));
            ListR.Add(new Recipe("Scallop Nigiri", "Nigiri", I.Rice, I.Scallop));
        }


        public Recipe FetchRecipe(string name) => ListR.Find(x => x.Name.ToLower() == name.ToLower());
        
        public Recipe[] FetchRecipes(params string[] names)
        {
            var recipes = new List<Recipe>(names.Length);

            foreach (var t in names) if(FetchRecipe(t) != null) recipes.Add(FetchRecipe(t));

            return recipes.ToArray();



            //recipes.AddRange(
            //    from t in names
            //    where FetchRecipe(t) != null
            //    select FetchRecipe(t));

        }
    }
}
