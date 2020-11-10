using System;
using System.Collections.Generic;
using System.Text;

namespace laba2
{
    public static class ChainOfStores
    {
        
        public static Shop FindMinPrice(List<Shop> shops, string nameOfProduct)
        {
            int minPrice = int.MaxValue; 
            Shop minPriceShop = null;
            foreach (Shop shop in shops)
            {
                if (!shop.TryGetShowPrice(nameOfProduct))
                    continue;
                int priceInThisShop = shop.ShowPrice(nameOfProduct);
                if (priceInThisShop < minPrice)
                {
                    minPrice = priceInThisShop;
                    minPriceShop = shop;
                }
            }
            return minPriceShop;
        }



        public static Shop FindMinShopBatchOfProduct(List<Shop> shops, List<ProductCount> productCounts)
        {
            int minPrice = int.MaxValue; 
            Shop minShop = null;
            foreach (Shop shop in shops)
            {
                int priceInThisShop;
                
                priceInThisShop = shop.BuyBatchProducts(productCounts);
                if (priceInThisShop < minPrice && priceInThisShop != default(int))
                {
                    minPrice = priceInThisShop;
                    minShop = shop;
                }
            }
            return minShop;
        }
    }
}
