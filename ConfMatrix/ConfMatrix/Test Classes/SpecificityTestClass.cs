using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfMatrix.Test_Classes
{
    [TestFixture]
    class SpecificityTestClass
    {
        Calc calc1 = new Calc("0", "-1", "-1", "0");
        Calc calc2 = new Calc("10", "20", "0", "5");
        Calc calc3 = new Calc("50", "20", "40", "15");
        Calc calc4 = new Calc("", "", "40", "15");
        Calc calc5 = new Calc("-1", "123", "40", "15");
        Calc calc6 = new Calc("-1", "", "ab", "abcd");
        Calc calc7 = new Calc("ab", "40", "wow", "!");

        [Test]
        public void TestSpecificity1()
        {
            float actual = calc1.specificity();
            float expected = 0.0f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSpecificity2()
        {
            float actual = calc2.specificity();
            float expected = 0.0f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSpecificity3()
        {
            float actual = calc3.specificity();
            float expected = 0.666666687f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSpecificity4()
        {
            float actual = calc4.specificity();
            float expected = 0.0f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSpecificity5()
        {
            float actual = calc5.specificity();
            float expected = -1.0f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSpecificity6()
        {
            float actual = calc6.specificity();
            float expected = 0.0f;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSpecificity7()
        {
            float actual = calc7.specificity();
            float expected = -1.0f;
            Assert.AreEqual(expected, actual);
        }

    }
}
