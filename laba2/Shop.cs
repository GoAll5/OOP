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
        public List<Product> products;

        public Shop()
        {
            products = new List<Product>();
            Id = -1;
            Name = "none";
            Address = "none";
        }

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

                    if (idOfProduct == products[i].ShowId())
                    {
                        products[i].ChangePrice(newPrice);
                        return;
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

        
        public List<ProductCount> CanBuyProductsForMoney(int money)
        {
            List<ProductCount> canBuyProducts = new List<ProductCount>();
            foreach(Product product in products)
            {
                int count = 0;
                while(money >= (product.ShowPrice()*(count+1)) && count+1 <= product.ShowAmount())
                {
                    count++;
                }

                canBuyProducts.Add(new ProductCount(product.ShowName(), count));
            }
            return canBuyProducts;
        }

        
        public int BuyBatchProducts(List<ProductCount> productCounts)
        {
            int money = 0;
            bool haveProduct;
            foreach(ProductCount productCount in productCounts)
            {
                haveProduct = false;
                foreach (Product product in products)
                {   

                    if(productCount.Name == product.ShowName())
                    {
                        if (productCount.Amount <= product.ShowAmount())
                        { 
                            money += product.ShowPrice() * productCount.Amount;
                            haveProduct = true;
                            break;
                        }
                    }
                    
                }
                if (!haveProduct)
                    return -1;
            }
            return money;
        }

        public bool Equals(Shop obj)
        {
            return this.Id == obj.Id;
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
