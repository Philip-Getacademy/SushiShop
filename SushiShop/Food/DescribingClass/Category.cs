using SushiShop.Misc;

namespace SushiShop.Food
{
    class Category
    {
        private Name name { get; set; }

        public Category(string name)
        {
            this.name = new Name(name);
        }

        public string Name => name.ThisName;
    }
}
