using SushiShop.Food;

namespace SushiShop.RegistryKiosk.CollectionClass
{
    class Menu
    {
        private Recipes Recipes { get; set; }
        private Categories Categories { get; set; }


        public Menu()
        {
            Recipes = new Recipes();
            Categories = new Categories();
        }
    }
}
