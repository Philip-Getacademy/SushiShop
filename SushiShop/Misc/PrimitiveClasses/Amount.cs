using System;
using System.Collections.Generic;
using System.Text;

namespace SushiShop.Misc
{
    class Amount
    {
        private int Value { get; set; }

        public Amount(int amount)
        {
            Value = amount;
        }


        public int Count => Value;


        public void Decrease(int x) => Value = (Value - x >= 0) ? Value -= x : Value;
        public void Increase(int x) => Value += x;

    }
}
