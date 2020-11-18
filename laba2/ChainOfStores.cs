using System;
using System.Collections.Generic;
using System.Text;

namespace laba2
{
    public static class ChainOfStores
    {
        //! в отдельный класс, поиск по продуктам внутри магазина
        public static Shop FindMinPrice(List<Shop> shops, string nameOfProduct)
        {
            int minPrice = 2147483647; //MAX Price
            Shop minPriceShop = new Shop();
            foreach (Shop shop in shops)
            {
                int priceInThisShop = shop.ShowPriceName(nameOfProduct);
                if (priceInThisShop < minPrice && priceInThisShop != default(int))
                {
                    minPrice = priceInThisShop;
                    minPriceShop = shop;
                }
            }
            return minPriceShop;
        }



        public static Shop FindMinShopBatchOfProduct(List<Shop> shops, List<ProductCount> productCounts)
        {
            int minPrice = 2147483647; //MAX Price
            Shop minShop = new Shop();
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
