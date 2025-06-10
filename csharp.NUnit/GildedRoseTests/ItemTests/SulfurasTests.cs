using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests
{
    [TestFixture]
    public class SulfurasTests      // Quality always stays 80 , sellIn does not change
    {
        [Test]
        public void Sulfuras_QualityAndSellIn_DoNotChange()
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(5));
            Assert.That(item.Quality, Is.EqualTo(80));
        }

        [Test]
        public void Sulfuras_RemainsConstant_EvenAfterExpiration()
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(-1));
            Assert.That(item.Quality, Is.EqualTo(80));
        }
    }
}
