using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace laba2
{   
    
    public class Product
    {
        private readonly int Id;
        private readonly string Name;
        private readonly int Amount;
        private int Price;


        public Product(int id, string name, int amount, int price)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Price = price;
        }

        
        public void ChangePrice(int newPrice)
        {
            Price = newPrice;
        }

        public int ShowId()
        {
            return this.Id;
        }

        public string ShowName()
        {
            return this.Name;
        }

        public int ShowAmount()
        {
            return this.Amount;
        }
        public int ShowPrice()
        {
            return this.Price;
        }

    }
}
