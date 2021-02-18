

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SushiShop.Food;
using SushiShop.Misc;

namespace SushiShop.Economy
{
    class Receipt
    {
        private static ID GlobalId = new ID(10);
        private ID Id { get; }
        private DateTime TimeOfPurchase { get; }

        // Receipt formatting variables
        private const int P = 12;
        private readonly string S;
        private readonly List<ReceiptItem> OrderList;
        private double FetchVat25 => OrderList.Sum(x => x.Vat25);
        private double FetchTotal => OrderList.Sum(x => x.Value);

        public Receipt(int itemOrItems)
        {
            TimeOfPurchase = DateTime.Now;

            Id = new ID(GlobalId.GetID());
            GlobalId = new ID(GlobalId.NextID());

            S = itemOrItems > 1 ? "s" : "";
        }

        public Receipt(List<KeyValuePair<Ingredient, Amount>> order, int amount) : this(amount) 
        {

            OrderList = new List<ReceiptItem>();

            foreach (var (i, a) in order)
                OrderList.Add(new ReceiptItem(i, a, i.Price * a.Count));

        }

        public string GenerateReceipt()
        {
            var text = StartBuilder();

            text.AppendLine();
            text.AppendLine("--------------------------"  );
            text.AppendLine("     ** Sushi Shop **     "  );
            text.AppendLine("--------------------------"  );
            text.AppendLine($"  Item{S}   Pcs   Price  "  );

            text.AppendLine(
                
                OrderList.Aggregate("", 
                    (s, i) => s 
                              + i.SName.PadRight(P - i.SName.Length)
                              + i.SAmount.PadLeft(P - i.SName.Length)
                              + i.SPrice.PadLeft(P / 2 + 2)
                              + "\n")
            );

            text.AppendLine("---------------------------"   );
            text.AppendLine($"  Tax     : {FetchVat25:0.##}");
            text.AppendLine($"  Total   : {FetchTotal:0.##}");
            text.AppendLine($"  Ref. ID : {Id.GetID()}"     );
            text.AppendLine("---------------------------"   );
            text.AppendLine("      Time of purchase     "   );
            text.AppendLine($"     {TimeOfPurchase}"        );
            text.AppendLine("---------------------------"   );
            text.AppendLine();

            return text.ToString();
        }

        protected virtual StringBuilder StartBuilder() => new StringBuilder();
    }
}

