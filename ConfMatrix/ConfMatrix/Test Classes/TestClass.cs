using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfMatrix.Test_Classes
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void TestAllEmpty()
        {
            Calc allEmpty = new Calc("", "", "", "");

            Assert.AreEqual(allEmpty.precision(), 0.0f);
            Assert.AreEqual(allEmpty.sensitivity(), 0.0f);
            Assert.AreEqual(allEmpty.specificity(), 0.0f);
            Assert.AreEqual(allEmpty.f1Score(), 0.0f);
            Assert.AreEqual(allEmpty.accuracy(), 0.0f);
        }

        [Test]
        public void TestAllString()
        {
            Calc allString = new Calc("ab", "bc", "cd", "da");

            Assert.AreEqual(allString.accuracy(), -1.0f);
            Assert.AreEqual(allString.precision(), -1.0f);
            Assert.AreEqual(allString.sensitivity(), -1.0f);
            Assert.AreEqual(allString.specificity(), -1.0f);
            Assert.AreEqual(allString.f1Score(), -1.0f);
        }

        [Test]
        public void TestAllValidNumbers()
        {
            Calc allValidNum = new Calc("15352", "9489", "12028", "1234");

            Assert.AreEqual(allValidNum.accuracy(), 0.718578577f);
            Assert.AreEqual(allValidNum.precision(), 0.618010521f);
            Assert.AreEqual(allValidNum.sensitivity(), 0.925599933f);
            Assert.AreEqual(allValidNum.specificity(), 0.558999836f);
            Assert.AreEqual(allValidNum.f1Score(), 0.741159141f);
        }

        [Test]
        public void TestAllZero()
        {
            Calc allZero = new Calc("0", "0", "0", "0");

            Assert.AreEqual(allZero.precision(), 0.0f);
            Assert.AreEqual(allZero.sensitivity(), 0.0f);
            Assert.AreEqual(allZero.specificity(), 0.0f);
            Assert.AreEqual(allZero.f1Score(), 0.0f);
            Assert.AreEqual(allZero.accuracy(), 0.0f);
        }

        [Test]
        public void TestAllMinusOne()
        {
            Calc allMinusOne = new Calc("-1", "-1", "-1", "-1");

            Assert.AreEqual(allMinusOne.precision(), -1.0f);
            Assert.AreEqual(allMinusOne.sensitivity(), -1.0f);
            Assert.AreEqual(allMinusOne.specificity(), -1.0f);
            Assert.AreEqual(allMinusOne.f1Score(), -1.0f);
            Assert.AreEqual(allMinusOne.accuracy(), -1.0f);
        }
    }
}
