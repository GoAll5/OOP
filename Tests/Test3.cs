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
    }
}
