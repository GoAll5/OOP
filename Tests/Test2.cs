using NUnit.Framework;
using laba2;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //arrange 
            string name = "€блоко";
            int id = 1;
            int price = 30;
            int amount = 5;
            Assert.Pass();
        }
    }
}