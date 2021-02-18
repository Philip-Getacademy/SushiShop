using System;
using System.Collections.Generic;
using System.Text;

namespace SushiShop.Misc
{
    class ID
    {

        private int Id { get; set; }
        
        public ID() { }
        public ID(int id) { Id = id; }


        public int NextID()
        {
            Id++;

            return GetID();
        }

        public int GetID()
        {
            return Id;
        }
    }
}
