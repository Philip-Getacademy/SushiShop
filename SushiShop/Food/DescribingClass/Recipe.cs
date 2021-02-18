

using SushiShop.Misc;
using System.Collections.Generic;
using System.Linq;

namespace SushiShop.Food
{
    class Recipe
    {
        public Name RecipeName;
        public Category RecipeCategory;
        public Dictionary<Ingredient, Amount> Items { get; set; }

        public Recipe(string name, string recipeCategory, params Ingredient[] items)
        {
            RecipeCategory = new Category(recipeCategory);
            RecipeName = new Name(name);
            Items = BuildRecipe(items);
        }

        public string Name => RecipeName.SName;

        private Dictionary<Ingredient, Amount> BuildRecipe(params Ingredient[] items)
        {
            var Ingredients = ItemsBuilder;

            foreach (var ingr in items)
            {
                Ingredients[ingr] = new Amount(1);
            }

            return Ingredients;
        }


        public static List<Ingredient> Combine(params Recipe[] recipes)
        {
            var stats = new List<Ingredient>();

            foreach (var recipe in recipes)
                foreach (var (i, a) in recipe.Items)
                {
                    if (!stats.Contains(i)) 
                        stats.Add(new Ingredient(i.Name, i.Price, 0, i.SCategory));

                    stats.Find(f => f.Name.ToLower() == i.Name.ToLower())?.Increment(a.Count);
                }

            return stats;
        }

        private Dictionary<Ingredient, Amount> ItemsBuilder => new Dictionary<Ingredient, Amount>();
    }
}
