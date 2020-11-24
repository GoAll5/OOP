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
            Product product = products.Find(item => item.ShowId() == idOfProduct);
            if (product == null)
            {
                return;
            }
            product.ChangePrice(newPrice);
        }

        
        public int ShowPrice(int idOfProduct)
        {
                
                Product product = products.Find(item => item.ShowId() == idOfProduct);
                if (product == null)
                {
                    return default(int);
                }
                return product.ShowPrice();

        }
        public bool TryGetShowPrice(string NameOfProduct)
        {

            Product product = products.Find(item => item.ShowName() == NameOfProduct);
            return product != null;
        }
        public int ShowPrice(string NameOfProduct)
        {
        Product product = products.Find(item => item.ShowName() == NameOfProduct);
        return product.ShowPrice();
        }


        public List<ProductCount> CanBuyProductsForMoney(int money)
        {
            List<ProductCount> canBuyProducts = new List<ProductCount>();
            foreach(Product product in products)
            {
                int count = money / product.ShowPrice();
                if (count > product.ShowAmount())
                {
                    canBuyProducts.Add(new ProductCount(product.ShowName(), product.ShowAmount()));
                }
                else
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
                    return default(int);
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
