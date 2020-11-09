using System;
using System.Collections.Generic;
using System.Text;

namespace laba2
{
    public class ProductCount
    {
        public string Name;
        public int Amount;

        public bool Equals(ProductCount obj)
        {
            return this.Name == obj.Name && this.Amount == obj.Amount;
        }
        public ProductCount(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }

    }
}
