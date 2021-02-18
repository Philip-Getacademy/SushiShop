using System;
using System.Collections.Generic;
using System.Text;

namespace SushiShop.Misc
{
    class ID
    {
        public ID(int id)
        {
            _identityNumber = id;
        }

        private int _identityNumber { get; set; }


        public int GetID()
        {
            return _identityNumber;
        }
    }
}
