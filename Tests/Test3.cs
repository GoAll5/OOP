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
            Transport ts = new Bactrian("Двугорбый верблюд", 10, 30);
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
        public void TestAir()
        {
            //arrange 


            //act
            string expected = "MeAir";
            Transport ts6 = new Broom("Метла", 20);
            Transport ts7 = new FlyCarpet("Ковер-самолет", 10);
            Transport ts8 = new Mortar("Ступа", 8);
            Transport ts9 = new MyAir("MeAir", 100, 50);
            List<Transport> ts = new List<Transport>();
            ts.Add(ts6);
            ts.Add(ts7);
            ts.Add(ts8);
            ts.Add(ts9);

            Race<Transport> race = new Race<Transport>(1000, ts);
            Transport first = race.Champion();
            string actual = first.Name;

            Assert.AreEqual(expected, actual);
            //assert ожидали - получили

        }

        [Test]
        public void TestLand()
        {
            //arrange 


            //act
            string expected = "Ботинки-вездеходы";
            Transport ts1 = new Bactrian("Двугорбый верблюд", 10, 30);
            Transport ts2 = new AllTerainBoots("Ботинки-вездеходы", 6, 60);
            Transport ts3 = new CamelSpeedBoat("Верблюд-быстроход", 40, 10);
            Transport ts4 = new Centaur("Кентавр", 15, 8);
            Transport ts5 = new MyLand("MeLand", 10, 10, 5);
            
            List<Transport> ts = new List<Transport>();
            ts.Add(ts1);
            ts.Add(ts2);
            ts.Add(ts3);
            ts.Add(ts4);
            ts.Add(ts5);
            Race<Transport> race = new Race<Transport>(1000, ts);
            Transport first = race.Champion();
            string actual = first.Name;

            Assert.AreEqual(expected, actual);
            //assert ожидали - получили

        }

        [Test]
        public void TestLandAndAir()
        {
            //arrange 


            //act
            string expected = "MeAir";
            Transport ts1 = new Bactrian("Двугорбый верблюд", 10, 30);
            Transport ts2 = new AllTerainBoots("Ботинки-вездеходы", 6, 60);
            Transport ts3 = new CamelSpeedBoat("Верблюд-быстроход", 40, 10);
            Transport ts4 = new Centaur("Кентавр", 15, 8);
            Transport ts5 = new MyLand("MeLand", 10, 10, 5);
            Transport ts6 = new Broom("Метла", 20);
            Transport ts7 = new FlyCarpet("Ковер-самолет", 10);
            Transport ts8 = new Mortar("Ступа", 8);
            Transport ts9 = new MyAir("MeAir", 100, 50);

            List<Transport> ts = new List<Transport>();
            ts.Add(ts1);
            ts.Add(ts2);
            ts.Add(ts3);
            ts.Add(ts4);
            ts.Add(ts5);
            ts.Add(ts6);
            ts.Add(ts7);
            ts.Add(ts8);
            ts.Add(ts9);

            Race<Transport> race = new Race<Transport>(1000, ts);
            Transport first = race.Champion();
            string actual = first.Name;

            Assert.AreEqual(expected, actual);
            //assert ожидали - получили

        }
        public void TestOnlyLand()
        {
            //arrange 


            //act
            string expected = "Ботинки-вездеходы";
            LandTransport ts1 = new Bactrian("Двугорбый верблюд", 10, 30);
            LandTransport ts2 = new AllTerainBoots("Ботинки-вездеходы", 6, 60);
            LandTransport ts3 = new CamelSpeedBoat("Верблюд-быстроход", 40, 10);
            LandTransport ts4 = new Centaur("Кентавр", 15, 8);
            LandTransport ts5 = new MyLand("MeLand", 10, 10, 5);
            List<LandTransport> ts = new List<LandTransport>();
            ts.Add(ts1);
            ts.Add(ts2);
            ts.Add(ts3);
            ts.Add(ts4);
            ts.Add(ts5);
            LandTsRace race = new LandTsRace(1000, ts);
            Transport first = race.Champion();
            string actual = first.Name;

            Assert.AreEqual(expected, actual);
            //assert ожидали - получили

        }

        [Test]
        public void TestOnlyAir()
        {
            //arrange 


            //act
            string expected = "MeAir";
            AirTransport ts6 = new Broom("Метла", 20);
            AirTransport ts7 = new FlyCarpet("Ковер-самолет", 10);
            AirTransport ts8 = new Mortar("Ступа", 8);
            AirTransport ts9 = new MyAir("MeAir", 100, 50);
            List<AirTransport> ts = new List<AirTransport>();
            ts.Add(ts6);
            ts.Add(ts7);
            ts.Add(ts8);
            ts.Add(ts9);

            AirTsRace race = new AirTsRace(1000, ts);
            Transport first = race.Champion();
            string actual = first.Name;

            Assert.AreEqual(expected, actual);
            //assert ожидали - получили

        }
    }
}
