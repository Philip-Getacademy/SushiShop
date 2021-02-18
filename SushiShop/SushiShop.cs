
using SushiShop.Food;
using SushiShop.Misc;
using SushiShop.RegistryKiosk;

namespace SushiShop
{
    class SushiShop
    {
        static void Main(string[] args)
        {

            var Stock = new Ingredients(); 
            Stock.ListCurrentStock();

            var Kiosk = new Kiosk();
            Kiosk.Run();
            Kiosk.OrderItem("Salmon Nigiri", 1);
            Kiosk.OrderItem("Scallop Nigiri", 1);

        }
    }
}
