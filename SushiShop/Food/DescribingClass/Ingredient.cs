using SushiShop.Misc;

namespace SushiShop.Food
{
    class Ingredient
    {

        private Name IngredientName { get; }
        private Price IngredientPrice { get; }
        private Amount IngredientAmount { get; }

        public ID Id { get; }
        private static ID GlobalId = new ID();
        
        private Category IngredientCategory { get;  }

        public Ingredient(string name, double price, int amount, string category)
        {
            IngredientName = new Name(name);
            IngredientPrice = new Price(price);
            IngredientAmount = new Amount(amount);
            IngredientCategory = new Category(category);

            Id = new ID(GlobalId.GetID());
            GlobalId = new ID(GlobalId.NextID());
        }

        public string Name => IngredientName.SName;
        public double Price => IngredientPrice.Value;
        public int Amount => IngredientAmount.Count;
        public Category Category => IngredientCategory;
        public string SCategory => IngredientCategory.SName;

        public void Decrement(int x) => IngredientAmount.Decrease(x);
        public void Increment(int x) => IngredientAmount.Increase(x);

    }
}
