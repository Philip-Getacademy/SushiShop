using SushiShop.Misc;

namespace SushiShop.Food
{
    class Ingredient
    {
        public Name IngredientName { get; }
        public Price IngredientPrice { get; }
        public Amount IngredientAmount { get; }

        public static ID GlobalId = new ID();
        public ID Id { get; }
        public Category Category { get; }

        public Ingredient(string name, int price, int amount, string category)
        {
            IngredientName = new Name(name);
            IngredientPrice = new Price(price);
            IngredientAmount = new Amount(amount);
            Category = new Category(category);

            Id = new ID(GlobalId.GetID());
            GlobalId = new ID(GlobalId.NextID());
        }

        public string Name => IngredientName.ThisName;
        public double Price => IngredientPrice.Value;
        public int Amount => IngredientAmount.Count;
    }
}
