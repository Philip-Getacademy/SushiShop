using System;
using System.Collections.Generic;
using System.Text;

namespace SushiShop.Misc
{
    class Amount
    {
        public Amount(int v)
        {
            V = v;
        }

        public int V { get; }
        private int _amount { get; set; }
    }
}
