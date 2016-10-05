using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TestDAO;
namespace UnitTest
{
    [TestFixture]
    public class TestCalculate
    {
        [Test]
        public void TestAdd()
        {
            Calculate objCalculate = new Calculate();
            int result = objCalculate.Add(2, 3);
            Assert.AreEqual(5, result);

        }
        [Test]
        public void TestMul()
        {
            Calculate obj = new Calculate();
            int result = obj.Mul(3, 4);
            Assert.AreEqual(12, result);
        }
    }
}
