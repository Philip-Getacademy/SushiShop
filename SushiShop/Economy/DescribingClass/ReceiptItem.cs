

using SushiShop.Misc;
using SushiShop.Food;

namespace SushiShop.Economy
{
    class ReceiptItem
    {
        private Ingredient ingredient { get; }
        private Amount amount { get; }
        private Price price { get; }

        public ReceiptItem(Ingredient ingredient, Amount amount, double price)
        {
            this.ingredient = ingredient;
            this.amount = amount;
            this.price = new Price(price);
        }

        public string SName   => $"  {ingredient.Name}";
        public string SAmount => $"{amount.Count}";
        public string SPrice  => $"{ingredient.Price:0.##}";

        public int Amount => amount.Count;
        public double Vat25 => price.Vat25;
        public double Value => price.Value;
    }
}
