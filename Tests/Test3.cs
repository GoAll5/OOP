using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using laba3.Land;
using laba3;
using laba3.Air;

namespace Tests
{
    [TestFixture]
    class Test3
    {
        [SetUp]
        public void SetUp()
        {
           
        }
        [Test]
        public void TestBactian()
        {
            //arrange 


            //act
            double expected = 31;
            Transport ts = new Bactrian();
            double actual = ts.Result(100);

            Assert.AreEqual(expected, actual);
            //assert ожидали - получили
            
        }
        [TestCase("MeAir", 100, 50, 5)]
        public void TestMyAir(string name, int speed, double reduce, double answer)
        {
            //arrange 


            //act
            double expected = answer;
            Transport ts = new MyAir(name, speed, reduce);
            double actual = ts.Result(1000);

            Assert.AreEqual(expected, actual);
            //assert ожидали - получили

        }

        [TestCase("MeLand", 10, 10, 5, 595)]
        public void TestMyAir(string name, int speed, int rest, int timeChill, double answer)
        {
            //arrange 


            //act
            double expected = answer;
            Transport ts = new MyLand(name, speed, rest, timeChill);
            double actual = ts.Result(1000);

            Assert.AreEqual(expected, actual);
            //assert ожидали - получили

        }
    }
}
