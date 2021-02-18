using SushiShop.Economy;
using System.Collections.Generic;

namespace SushiShop.Misc
{
    class Customer
    {
        private ID _transactionId { get; set; }
        private Amount _money { get; set; }
        private Dictionary<ID, Receipt> _receiptItems { get; set; }
    }
}
