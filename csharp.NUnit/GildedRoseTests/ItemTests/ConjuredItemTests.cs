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
    public class ConjuredItemTests
    {
        [Test]
        public void ConjuredItem_DegradesTwiceAsFast_BeforeSellDate()
        {
            var item = new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 10 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(2));
            Assert.That(item.Quality, Is.EqualTo(8));
        }

        [Test]
        public void ConjuredItem_DegradesFour_AfterSellDate()
        {
            var item = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 10 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(-1));
            Assert.That(item.Quality, Is.EqualTo(6));
        }

        [Test]
        public void ConjuredItem_QualityNeverGoesBelowZero()
        {
            var item = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 3 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(-1));
            Assert.That(item.Quality, Is.EqualTo(0));
        }
    }
}
