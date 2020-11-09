using System;
using System.Collections.Generic;
using System.Text;

namespace laba2
{
    public class ProductCount
    {
        public string Name;
        public int Amount;

        public ProductCount()
        {
            Name = "none";
            Amount = 0;
        }
        public ProductCount(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }

    }
}
