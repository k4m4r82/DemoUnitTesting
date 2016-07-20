using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CalculatorLib;
using NUnit.Framework;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calculator;

        [SetUp]
        public void Init()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TambahTest()
        {
            var hasil = calculator.Tambah(5, 2);
            Assert.AreEqual(7, hasil);
        }

        [Test]
        public void KurangTest()
        {
            var hasil = calculator.Kurang(5, 2);
            Assert.AreEqual(3, hasil);
        }

        [Test]
        public void KaliTest()
        {
            var hasil = calculator.Kali(5, 2);
            Assert.AreEqual(10, hasil);
        }

        [Test]
        public void BagiTest()
        {
            var hasil = calculator.Bagi(10, 2);
            Assert.AreEqual(5, hasil);
        }
    }
}
