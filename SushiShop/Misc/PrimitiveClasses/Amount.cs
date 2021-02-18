using System;
using System.Collections.Generic;
using System.Text;

namespace SushiShop.Misc
{
    class Amount
    {
        private int Value { get; }

        public Amount(int amount)
        {
            Value = amount;
        }


        public int Count => Value;

    }
}
