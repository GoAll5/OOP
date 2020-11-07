using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace laba2
{
    class Product
    {
        public int Id { private set; get; }
        public string Name { private set; get; }
        public int Amount { private set; get; }
        public int Price { private set; get; }


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


        //public Product Show()
        //{
        //    return this;
        //}

        //public int ShowId()
        //{
        //    return this.id;
        //}

        //public string ShowName()
        //{
        //    return this.name;
        //}

    }
}
