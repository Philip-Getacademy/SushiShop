using SushiShop.Misc;

using System.Collections.Generic;
using System.Linq;

namespace SushiShop.Food
{
    class Categories
    {
        public List<Category> Cs { get; }
        public Ingredients I { get; }

        public Categories()
        {
            I = new Ingredients();
            Cs = new List<Category>();

            BuildI();
        }

        private void BuildI()
        {
            foreach (var I in I.I.Where(I => !Cs.Contains(I.Category)))
            {
                Cs.Add(I.Category);
            }
        }
    }
}
