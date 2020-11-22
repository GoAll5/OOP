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
        public void TestMyLand(string name, int speed, int rest, int timeChill, double answer)
        {



            double expected = answer;
            Transport ts = new MyLand(name, speed, rest, timeChill);
            double actual = ts.Result(1000);

            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void TestLand()
        {
            //arrange 


            //act
            string expected = "Ботинки-вездеходы";
            Transport ts1 = new Bactrian();
            Transport ts2 = new AllTerainBoots();
            Transport ts3 = new CamelSpeedBoat();
            Transport ts4 = new Centaur();
            Transport ts5 = new MyLand("MeLand", 10, 10, 5);
            List<Transport> ts = new List<Transport>();
            ts.Add(ts1);
            ts.Add(ts2);
            ts.Add(ts3);
            ts.Add(ts4);
            ts.Add(ts5);
            Race<Transport> race = new Race<Transport>(1000, ts);
            Transport first = race.FirstPlayer();
            string actual = first.Name;

            Assert.AreEqual(expected, actual);
            //assert ожидали - получили

        }
    }
}
