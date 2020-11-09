using System;
using System.Collections.Generic;
using System.Text;

namespace laba2
{
    public class Program
    {

        static void Main()
        {
            Console.WriteLine(default(int));
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
            Product product27 = new Product(27, "клубника", 20, 180);
            Product product28 = new Product(28, "финики", 34, 100);
            Product product29 = new Product(29, "чернослив", 100, 4);
            Product product30 = new Product(20, "капуста", 10, 60);
            Product product31 = new Product(21, "орехи", 34, 110);
            Product product32 = new Product(22, "макароны", 44, 74);
            Product product33 = new Product(23, "хлеб", 30, 20);
            Product product34 = new Product(24, "скумбрия", 15, 105);
            Product product35 = new Product(25, "гвозди", 12, 35);
            Product product36 = new Product(26, "гвозди", 5, 40);

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
            shop1.AddProduct(product9);
            shop1.AddProduct(product10);


            Shop shop2 = new Shop(2, "Ашан", "Парфеновская");
            shop2.AddProduct(product11);
            shop2.AddProduct(product12);
            shop2.AddProduct(product13);
            shop2.AddProduct(product14);
            shop2.AddProduct(product15);
            shop2.AddProduct(product27);
            shop2.AddProduct(product28);
            shop2.AddProduct(product29);
            shop2.AddProduct(product30);
            shop2.AddProduct(product31);
            shop2.AddProduct(product32);
            shop2.AddProduct(product33);
            shop2.AddProduct(product34);
            shop2.AddProduct(product35);
            shop2.AddProduct(product36);



            Shop shop3 = new Shop(3, "fixprice", "Фрунзенская");
            shop3.AddProduct(product16);
            shop3.AddProduct(product17);
            shop3.AddProduct(product18);
            shop3.AddProduct(product19);
            shop3.AddProduct(product20);
            shop3.AddProduct(product21);
            shop3.AddProduct(product22);
            shop3.AddProduct(product23);
            shop3.AddProduct(product24);
            shop3.AddProduct(product25);
            shop3.AddProduct(product26);



            shop3.ChangePrice(16, 10);
            shop3.ChangePrice(17, 10);
            shop3.ChangePrice(18, 10);
            shop3.ChangePrice(19, 10);
            shop3.ChangePrice(20, 10);
            shop3.ChangePrice(21, 10);
            shop3.ChangePrice(22, 10);
            shop3.ChangePrice(23, 10);
            shop3.ChangePrice(24, 10);
            shop3.ChangePrice(25, 10);
            shop3.ChangePrice(26, 10);
            
            
            List<ProductCount> products = new List<ProductCount>();
            products = shop3.CanBuyProductsForMoney(100);
            Console.WriteLine();
            foreach (ProductCount product in products)
            {
                Console.WriteLine(product.Name + "  " + product.Amount);
            }

            ProductCount productCount21 = new ProductCount("орехи", 14);
            ProductCount productCount22 = new ProductCount("макароны", 13); //44
            ProductCount productCount23 = new ProductCount("хлеб", 2);
            ProductCount productCount24 = new ProductCount("скумбрия", 10);
            ProductCount productCount25 = new ProductCount("гвозди", 5);
            ProductCount productCount26 = new ProductCount("гвозди", 3);

            List<ProductCount> productCounts = new List<ProductCount>();
            productCounts.Add(productCount21);
            productCounts.Add(productCount22);
            productCounts.Add(productCount23);
            productCounts.Add(productCount24);
            productCounts.Add(productCount25);
            productCounts.Add(productCount26);

            int howMuch = shop3.BuyBatchProducts(productCounts);

            Console.WriteLine(howMuch);

            shops.Add(shop1);
            shops.Add(shop2);
            shops.Add(shop3);

            Shop AnswerMinPriceShow;
            AnswerMinPriceShow = ChainOfStores.FindMinShopBatchOfProduct(shops, productCounts);
            Console.WriteLine(AnswerMinPriceShow.ShowName());

            AnswerMinPriceShow = ChainOfStores.FindMinPrice(shops, "клубника");
            Console.WriteLine(AnswerMinPriceShow.ShowName());
        }
    }
}
