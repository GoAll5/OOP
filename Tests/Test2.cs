using NUnit.Framework;
using laba2;

namespace Tests
{   
    [TestFixture]
    public class Tests
    {

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
        //[TestCase(4, TestName ="4 = 4", ExpectedResult = 4)]
        //[Test]
        [TestCase(4, 1, TestName = "TestChange_4 = 4", ExpectedResult = 4)]
        [TestCase(25, 2, TestName = "TestChange_25 = 25", ExpectedResult = 25)]
        [TestCase(10, 3, TestName = "TestChange_10 = 10", ExpectedResult = 10)]
        [TestCase(100, 4, TestName = "TestChange_25 = 25", ExpectedResult = 100)]
        [TestCase(100, 5, TestName = "TestChange_100 != -1", ExpectedResult = -1)]
        public int TestChange(int price, int id)
        {
            Product product1 = new Product(1, "яблоко", 10, 35);
            Product product2 = new Product(2, "груша", 20, 30);
            Product product3 = new Product(3, "лук зеленый", 10, 100);
            Product product4 = new Product(4, "лук репчатый", 33, 60);

            Shop shops = new Shop(1, "Магазин1", "Кронва");
            shops.AddProduct(product1);
            shops.AddProduct(product2);
            shops.AddProduct(product3);
            shops.AddProduct(product4);
            shops.ChangePrice(id, price);

            return shops.ShowPrice(id);
        } 
    }
}