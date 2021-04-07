using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yksikkötestaus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yksikkötestaus.Tests
{
    [TestClass()]
    public class LaskentaTests
    {
        [TestMethod()]
        public void SummaTest()
        {
            int a = 100;
            int b = 200;

            Laskenta laskenta = new();
            int summa = laskenta.Summa(a, b);

            int odotettu = a + b;

            Assert.AreEqual(odotettu, summa);
        }

        [TestMethod()]
        public void SummaTest2()
        {
            int a = -100;
            int b = -200;

            Laskenta laskenta = new();
            int summa = laskenta.Summa(a, b);

            int odotettu = a + b;

            Assert.AreEqual(odotettu, summa);
        }
    }
}