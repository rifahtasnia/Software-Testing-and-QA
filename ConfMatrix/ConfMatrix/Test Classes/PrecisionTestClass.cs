using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfMatrix.Test_Classes
{
    [TestFixture]
    class PrecisionTestClass
    {
        Calc calc1 = new Calc("0", "-1", "-1", "0");
        Calc calc2 = new Calc("10", "20", "0", "5");
        Calc calc3 = new Calc("50", "20", "40", "15");
        Calc calc4 = new Calc("", "", "40", "15");
        Calc calc5 = new Calc("-1", "123", "40", "15");
        Calc calc6 = new Calc("-1", "", "ab", "abcd");
        Calc calc7 = new Calc("ab", "40", "wow", "!");
        [Test]
        public void TestPrecision1()
        {
            float actual = calc1.precision();
            float expected = 0.0f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestPrecision2()
        {
            float actual = calc2.precision();
            float expected = 0.0f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestPrecision3()
        {
            float actual = calc3.precision();
            float expected = 0.714285731f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestPrecision4()
        {
            float actual = calc4.precision();
            float expected = 0.0f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestPrecision5()
        {
            float actual = calc5.precision();
            float expected = -1.0f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestPrecision6()
        {
            float actual = calc6.precision();
            float expected = 0.0f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestPrecision7()
        {
            float actual = calc7.precision();
            float expected = -1.0f;
            Assert.AreEqual(expected, actual);
        }

    }
}
