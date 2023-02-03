using System;
using System.Globalization;
using NUnit.Framework;

namespace Mathematics.Tests
{
    [TestFixture]
    public class Tests
    {
        private BasicMaths bm;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine($"Initialisation BM à {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}");
            bm = new BasicMaths();
        }
        
        [Test]
        public void TestAlwaysTrue()
        {
            Assert.True(true);
        }

        [Test]
        public void Test_AddMethod()
        {
            double res = bm.Add(10, 10);
            Assert.AreEqual(20, res);
        }

        [Test]
        public void Test_SubstractMethod()
        {
            double res = bm.Substract(10, 10);
            Assert.AreEqual(0, res);
        }

        [Test]
        public void Test_DivideMethod()
        {
            double res = bm.Divide(10, 5);
            Assert.AreEqual(2, res);
        }

        [Test]
        public void Test_DivideBy0()
        {
            double res = bm.Divide(10, 0);
            Assert.AreEqual(-1, res);
        }

        [Test]
        public void Test_MultiplyMethod()
        {
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(100, res);
        }
    }
}