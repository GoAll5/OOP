using System;
using System.Collections.Generic;
using System.Text;

namespace laba2
{
    class Program
    {
        //!
        public Shop FindMinPrice(List<Shop> shops, string nameOfProduct)
        {
            int minPrice = -1;
            Shop minPriceShop = new Shop();
            for(int i = 0; i < shops.Count; i++)
            {   for (int j = 0; j < shops[i].products.Count; j++)
                {
                    if (shops[i].products[j].ShowName() == nameOfProduct)
                    {
                        if (minPrice == -1 || shops[i].products[j].ShowPrice() < minPrice)
                        {
                            minPrice = shops[i].products[j].ShowPrice();
                            minPriceShop = shops[i];
                        }
                    }
                }
            }
            return minPriceShop;
        }

        

        //!
        public Shop FindMinShopBatchOfProduct(List<Shop> shops, List<ProductCount> productCounts)
        {
            int minPrice = -1;
            Shop minShop = new Shop();
            foreach (Shop shop in shops)
            {
                int priceInThisShop;
                priceInThisShop = shop.BuyBatchProducts(productCounts);
                if (minPrice == -1 || priceInThisShop < minPrice)
                {
                    minPrice = priceInThisShop;
                    minShop = shop;
                }
            }
            return minShop;
        }

        static void Main()
        {

            Product product1 = new Product(1, "яблоко", 10, 35);
            Product product2 = new Product(2, "груша", 20, 30);
            Product product3 = new Product(3, "лук зеленый", 10, 100);
            Product product4 = new Product(4, "лук репчатый", 33, 60);
            Product product5 = new Product(5, "банан", 10, 40);
            Product product6 = new Product(6, "мандарин", 8, 65);
            Product product7 = new Product(7, "апельсин", 3, 55);
            Product product8 = new Product(25, "вода", 10, 35);
            Product product9 = new Product(9, "молоток", 10, 35);
            Product product10 = new Product(10, "шуруп", 10, 35);
            Product product11 = new Product(11, "картофель", 10, 35);
            Product product12 = new Product(12, "йогурт", 10, 35);
            Product product13 = new Product(13, "помидор", 10, 35);
            Product product14 = new Product(14, "виноград", 10, 35);
            Product product15 = new Product(15, "черешня", 10, 35);
            Product product16 = new Product(16, "голубика", 20, 150);
            Product product17 = new Product(17, "клубника", 20, 180);
            Product product18 = new Product(18, "финики", 34, 100);
            Product product19 = new Product(19, "чернослив", 100, 4);
            Product product20 = new Product(20, "капуста", 10, 60);
            Product product21 = new Product(21, "орехи", 34, 110);
            Product product22 = new Product(22, "макароны", 44, 74);
            Product product23 = new Product(23, "хлеб", 30, 20);
            Product product24 = new Product(24, "скумбрия", 15, 105);
            Product product25 = new Product(25, "гвозди", 12, 35);
            Product product26 = new Product(26, "гвозди", 5, 40);

            List<Shop> shops = new List<Shop>();

            Shop shop1 = new Shop(1, "Пятерочка", "Пушкинская");
            shop1.AddProduct(product1);
            shop1.AddProduct(product2);
            shop1.AddProduct(product3);
            shop1.AddProduct(product4);
            shop1.AddProduct(product5);
            shop1.AddProduct(product6);
            shop1.AddProduct(product7);
            shop1.AddProduct(product8);
            shop1.CanBuyProductsForMoney(100);
        }
    }
}
