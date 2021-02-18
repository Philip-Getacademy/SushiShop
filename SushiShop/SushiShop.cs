
using SushiShop.Food;
using SushiShop.ShopKiosk;
using SushiShop.RegistryKiosk;
using SushiShop.RegistryKiosk.CollectionClass;

namespace SushiShop
{
    class SushiShop
    {
        static void Main(string[] args)
        {

            var SushiShopKiosk = new AutomatedKiosk("SushiShop");
            SushiShopKiosk.Run();

            var selectedItems = new [] {"Scallop Nigiri", "Salmon Nigiri", "Salmon Nigiri"};
            SushiShopKiosk.Order(selectedItems);
                

        }
    }
}
