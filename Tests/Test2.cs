using NUnit.Framework;
using System.Collections.Generic;
using System;
using System.Text;
using laba2;

namespace Tests
{   
    [TestFixture]
    public class Tests
    {   
        [SetUp]
        public void SetUp()
        {
            Product product1 = new Product(1, "яблоко", 10, 35);
            Product product2 = new Product(2, "груша", 20, 30);
            Product product3 = new Product(3, "лук зеленый", 10, 100);
            Product product4 = new Product(4, "лук репчатый", 33, 60);

            Shop shop1 = new Shop(1, "Магазин1", "Кронва");
            shop1.AddProduct(product1);
            shop1.AddProduct(product2);
            shop1.AddProduct(product3);
            shop1.AddProduct(product4);
        }

        [Test]
        public void TestShow()
        {
            //arrange 
            string name = "яблоко";
            int id = 1;
            int price = 30;
            int amount = 5;
            //act
            Product apple = new Product(id, name, amount, price);
            int expected = id;
            int actual = apple.ShowId();

            //assert ожидали - получили
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(4, 1, TestName = "TestChange_4 = 4", ExpectedResult = 4)]
        [TestCase(25, 2, TestName = "TestChange_25 = 25", ExpectedResult = 25)]
        [TestCase(10, 3, TestName = "TestChange_10 = 10", ExpectedResult = 10)]
        [TestCase(100, 4, TestName = "TestChange_25 = 25", ExpectedResult = 100)]
        public int TestChange(int price, int id)
        {
            Product product1 = new Product(1, "яблоко", 10, 35);
            Product product2 = new Product(2, "груша", 20, 30);
            Product product3 = new Product(3, "лук зеленый", 10, 100);
            Product product4 = new Product(4, "лук репчатый", 33, 60);

            Shop shop1 = new Shop(1, "Магазин1", "Кронва");
            shop1.AddProduct(product1);
            shop1.AddProduct(product2);
            shop1.AddProduct(product3);
            shop1.AddProduct(product4);
            shop1.ChangePrice(id, price);

            return shop1.ShowPrice(id);
        }

        [TestCase(100, 5)]
        public void TestChange1(int price, int id)
        {
            Product product1 = new Product(1, "яблоко", 10, 35);
            Product product2 = new Product(2, "груша", 20, 30);
            Product product3 = new Product(3, "лук зеленый", 10, 100);
            Product product4 = new Product(4, "лук репчатый", 33, 60);

            Shop shop1 = new Shop(1, "Магазин1", "Кронва");
            shop1.AddProduct(product1);
            shop1.AddProduct(product2);
            shop1.AddProduct(product3);
            shop1.AddProduct(product4);
            shop1.ChangePrice(id, price);
            int? expected = null;
            int actual = shop1.ShowPrice(id);

            Assert.AreEqual(expected.GetValueOrDefault(), actual);
        }

        [TestCase(100)]
        public void TestCanBuyProductForMoney(int money)
        {
            Product product5 = new Product(5, "скумбрия", 1, 35);
            Product product6 = new Product(6, "вода", 2, 30);
            Product product7 = new Product(7, "тыква", 3, 100);
            Product product8 = new Product(8, "дыня", 1, 60);

            List <ProductCount> products = new List <ProductCount>();
            //new ProductCount("скумбрия", 1), new ProductCount("вода", 2),
            //new ProductCount("тыкква", 1), new ProductCount("дыня", 1)
            products.Add(new ProductCount("скумбрия", 1));
            products.Add(new ProductCount("вода", 2));
            products.Add(new ProductCount("тыква", 1));
            products.Add(new ProductCount("дыня", 1));

            Shop shop2 = new Shop(1, "Магазин1", "Кронва");
            shop2.AddProduct(product5);
            shop2.AddProduct(product6);
            shop2.AddProduct(product7);
            shop2.AddProduct(product8);

            

            List<ProductCount> expected = products;
            List<ProductCount> actual = shop2.CanBuyProductsForMoney(money);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void TestCanBuyProductForMoney0(int money)
        {
            Product product5 = new Product(5, "скумбрия", 1, 35);
            Product product6 = new Product(6, "вода", 2, 30);
            Product product7 = new Product(7, "тыква", 3, 100);
            Product product8 = new Product(8, "дыня", 1, 60);

            List<ProductCount> products = new List<ProductCount>();
            //new ProductCount("скумбрия", 1), new ProductCount("вода", 2),
            //new ProductCount("тыкква", 1), new ProductCount("дыня", 1)
            products.Add(new ProductCount("скумбрия", 0));
            products.Add(new ProductCount("вода", 0));
            products.Add(new ProductCount("тыква", 0));
            products.Add(new ProductCount("дыня", 0));

            Shop shop2 = new Shop(1, "Магазин1", "Кронва");
            shop2.AddProduct(product5);
            shop2.AddProduct(product6);
            shop2.AddProduct(product7);
            shop2.AddProduct(product8);

            List<ProductCount> expected = products;
            List<ProductCount> actual = shop2.CanBuyProductsForMoney(money);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000)]
        public void TestCanBuyProductForMoney1000(int money)
        {
            Product product5 = new Product(5, "скумбрия", 1, 35);
            

            List<ProductCount> products = new List<ProductCount>();
            
            products.Add(new ProductCount("скумбрия", 1));
            

            Shop shop2 = new Shop(1, "Магазин1", "Кронва");
            shop2.AddProduct(product5);
            

            List<ProductCount> expected = products;
            List<ProductCount> actual = shop2.CanBuyProductsForMoney(money);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestBuyBatchProducts225()
        {
            Product product5 = new Product(5, "скумбрия", 1, 35);
            Product product6 = new Product(6, "вода", 2, 30);
            Product product7 = new Product(7, "тыква", 3, 100);
            Product product8 = new Product(8, "дыня", 1, 60);

            List<ProductCount> products = new List<ProductCount>();
            
            products.Add(new ProductCount("скумбрия", 1));
            products.Add(new ProductCount("вода", 1));
            products.Add(new ProductCount("тыква", 1));
            products.Add(new ProductCount("дыня", 1));

            Shop shop3 = new Shop(1, "Магазин1", "Кронва");
            shop3.AddProduct(product5);
            shop3.AddProduct(product6);
            shop3.AddProduct(product7);
            shop3.AddProduct(product8);

            int expected = 225;
            int actual = shop3.BuyBatchProducts(products);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestBuyBatchProducts1()
        {
            Product product5 = new Product(5, "скумбрия", 1, 35);
            Product product6 = new Product(6, "вода", 2, 30);
            Product product7 = new Product(7, "тыква", 3, 100);
            Product product8 = new Product(8, "дыня", 1, 60);

            List<ProductCount> products = new List<ProductCount>();

            products.Add(new ProductCount("скумбрия", 1));
            products.Add(new ProductCount("вода", 3));
            products.Add(new ProductCount("тыква", 1));
            products.Add(new ProductCount("дыня", 1));

            Shop shop3 = new Shop(1, "Магазин1", "Кронва");
            shop3.AddProduct(product5);
            shop3.AddProduct(product6);
            shop3.AddProduct(product7);
            shop3.AddProduct(product8);

            int expected = 0;
            int actual = shop3.BuyBatchProducts(products);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFindMinShopBatchOfProduct1()
        {
            Product product5 = new Product(5, "скумбрия", 1, 35);
            Product product6 = new Product(6, "вода", 2, 30);
            Product product7 = new Product(7, "тыква", 3, 100);
            Product product8 = new Product(8, "дыня", 1, 60);

            List<ProductCount> products = new List<ProductCount>();

            products.Add(new ProductCount("скумбрия", 1));
            products.Add(new ProductCount("вода", 1));
            products.Add(new ProductCount("тыква", 1));
            products.Add(new ProductCount("дыня", 1));

            Product product1 = new Product(1, "яблоко", 10, 35);
            Product product2 = new Product(2, "груша", 20, 30);
            Product product3 = new Product(3, "лук зеленый", 10, 100);
            Product product4 = new Product(4, "лук репчатый", 33, 60);

            Shop shop1 = new Shop(1, "Магазин1", "Кронва");
            shop1.AddProduct(product1);
            shop1.AddProduct(product2);
            shop1.AddProduct(product3);
            shop1.AddProduct(product4);

            Shop shop3 = new Shop(2, "Магазин2", "Парфеновская");
            shop3.AddProduct(product5);
            shop3.AddProduct(product6);
            shop3.AddProduct(product7);
            shop3.AddProduct(product8);

            List<Shop> shops = new List<Shop>();

            shops.Add(shop1);
            shops.Add(shop3);

            int expected = shop3.ShowId();
            int actual = (ChainOfStores.FindMinShopBatchOfProduct(shops, products)).ShowId();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestFindMinPrice1()
        {
            Product product5 = new Product(5, "скумбрия", 1, 35);
            Product product6 = new Product(6, "вода", 2, 30);
            Product product7 = new Product(7, "тыква", 3, 100);
            Product product8 = new Product(8, "дыня", 1, 60);


            Product product1 = new Product(1, "яблоко", 10, 35);
            Product product2 = new Product(2, "груша", 20, 30);
            Product product3 = new Product(3, "лук зеленый", 10, 100);
            Product product4 = new Product(4, "дыня", 33, 70);

            Shop shop1 = new Shop(1, "Магазин1", "Кронва");
            shop1.AddProduct(product1);
            shop1.AddProduct(product2);
            shop1.AddProduct(product3);
            shop1.AddProduct(product4);

            Shop shop3 = new Shop(2, "Магазин2", "Парфеновская");
            shop3.AddProduct(product5);
            shop3.AddProduct(product6);
            shop3.AddProduct(product7);
            shop3.AddProduct(product8);

            List<Shop> shops = new List<Shop>();

            shops.Add(shop1);
            shops.Add(shop3);

            int expected = 2;
            int actual = ChainOfStores.FindMinPrice(shops, "дыня").ShowId();

            Assert.AreEqual(expected, actual);
        }
    }
}