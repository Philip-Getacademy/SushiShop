

using SushiShop.Misc;
using System.Collections.Generic;

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

        public string Name => RecipeName.ThisName;

        private Dictionary<Ingredient, Amount> BuildRecipe(params Ingredient[] items)
        {
            var Ingredients = ItemsBuilder;

            foreach (var ingr in items)
            {
                Ingredients[ingr] = new Amount(1);
            }

            return Ingredients;
        }

        private Dictionary<Ingredient, Amount> ItemsBuilder => new Dictionary<Ingredient, Amount>();
    }
}
