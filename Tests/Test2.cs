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
            string name = "€блоко";
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
    }
}