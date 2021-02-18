using System.Linq;
using SushiShop.Economy;

namespace SushiShop.Misc
{
    public class Price
    {
        private double value { get; }

        public Price(double price)
        {
            value = price;
        }

        public double Value => value;
        public double Vat25 => value / 4;

        public Price SumOfPrices() => new Price(value);
        public Price SumOfPrices(params Price[] price) => new Price( price.ToList().Select(x => x.value).Sum() );

    }
}
