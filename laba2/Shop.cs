using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace laba2
{
    class Shop
    {
        private readonly int Id;
        private readonly string Name;
        private readonly string Address;
        private List<Product> products;

        Shop(int id, string name, string address)
        {
            products = new List<Product>();
            Id = id;
            Name = name;
            Address = address;
        }

        public void ChangePrice(int idOfProduct, int newPrice)
        {
            for (int i = 0; i < products.Count; i++)
            {
                try
                {
                    if (idOfProduct == products[i].ShowId())
                    {
                        products[i].ChangePrice(newPrice);
                        return;
                    }
                    throw new Exception("В магазине с айди \"" + Id + "\" не удалось найти продукт с айди:" + idOfProduct);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }
            }
        }
        public int ShowId()
        {
            return this.Id;
        }

        public string ShowName()
        {
            return this.Name;
        }

        public string ShowAddress()
        {
            return this.Address;
        }
    }
}
