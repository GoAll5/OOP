using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace laba2
{
    public class Shop
    {
        private readonly int Id;
        private readonly string Name;
        private readonly string Address;
        private List<Product> products;

        public Shop(int id, string name, string address)
        {
            products = new List<Product>();
            Id = id;
            Name = name;
            Address = address;
        }

        public void AddProduct(Product newProduct)
        {
            products.Add(newProduct);
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
        public int ShowPrice(int idOfProduct)
        {
            
            for (int i = 0; i < products.Count; i++)
            {
                try
                {
                    if (idOfProduct == products[i].ShowId())
                    {
                        return products[i].ShowPrice();
                    }
                    
                    throw new Exception("В магазине с айди \"" + Id + "\" не удалось найти продукт с айди:" + idOfProduct);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }
                
            }
            return -1;
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
