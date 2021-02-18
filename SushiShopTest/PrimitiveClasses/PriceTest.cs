using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SushiShop.Misc;

namespace SushiShopTest.PrimitiveClasses
{
    class PriceTest
    {
        [Test]
        public void TestOnePrice()
        {
            var OnePrice = new Price(50);
            var actual = OnePrice.Value;
            var expected = 50;

            Assert.AreEqual(actual, expected);

        }

        [Test]
        public void TestSeveralPriceTotal()
        {
            const int BatchSize = 20;
            var Orders = new Price[BatchSize];

            for (var i = 0; i < BatchSize; i++)
                Orders[i] = new Price(
                    i % 2 == 0 ? 40 :
                    i % 5 == 0 ? 20 :
                    i % 3 == 0 ? 75 : 100
                );

            var actual = Orders[0].SumOfPrices(Orders).Value;
            var expected = 1190;

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestSeveralPriceVat25()
        {
            const int BatchSize = 20;
            var Orders = new Price[BatchSize];

            for (var i = 0; i < BatchSize; i++)
                Orders[i] = new Price(
                    i % 2 == 0 ? 40 :
                    i % 5 == 0 ? 20 :
                    i % 3 == 0 ? 75 : 100
                );

            var actual = Orders[0].SumOfPrices(Orders).Vat25;
            var expected = 297.5d;

            Assert.AreEqual(actual, expected);
        }
    }
}