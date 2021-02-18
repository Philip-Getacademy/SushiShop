using SushiShop.Food;
using SushiShop.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SushiShop.ShopKiosk;

namespace SushiShop.Economy
{
    class Order
    {

        public readonly List<Recipe> ListR;
        public readonly bool ItemsInStock;


        public Order(Recipe[] order)
        {
            ListR.AddRange(order);
        }



        //private bool IsItemsInStock(List<Recipe> order) => S.ListI.All(x => x.Name == item && x.Amount > 0)
        // var stockPreOrder = S.ListI;
        // ListR.Add(receipt);
        // Console.WriteLine(receipt.GenerateReceipt());

    }
}
