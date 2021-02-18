using System;
using System.Collections.Generic;
using System.Text;

namespace SushiShop.Food
{
    class Recipes
    {
        private List<Recipe> R { get; }
        private Ingredients I { get; }

        public Recipes()
        {
            I = new Ingredients();
            R = new List<Recipe>();
            RecepieBuilder();
        }

        public List<Recipe> GetRecipeList => R;

        private void RecepieBuilder()
        {
            R.Add(new Recipe("Salmon Nigiri", "Nigiri", I.Rice, I.Salmon));
            R.Add(new Recipe("Scallop Nigiri", "Nigiri", I.Rice, I.Scallop));
        }


        
    }
}
