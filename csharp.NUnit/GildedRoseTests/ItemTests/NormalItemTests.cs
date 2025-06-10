using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using GildedRoseKata;
using System.Collections.Generic;

namespace GildedRoseTests
{
    [TestFixture]
    public class NormalItemTests
    {
        [Test]
        public void NormalItem_Degrades_By1_BeforeSellDate()    // normal item, standard behavior when sell date is not passed
        {
            var item = new Item { Name = "Basic Item", SellIn = 5, Quality = 10 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(4));
            Assert.That(item.Quality, Is.EqualTo(9));
        }

        [Test]
        public void NormalItem_QualityDegradesTwice_AsSellInExpires()   // function names say it all actually
        {
            var item = new Item { Name = "Basic Item", SellIn = 0, Quality = 10 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(-1));
            Assert.That(item.Quality, Is.EqualTo(8));
        }

        [Test]
        public void NormalItem_QualityNeverGoesNegative()
        {
            var item = new Item { Name = "Basic Item", SellIn = 0, Quality = 0 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(-1));
            Assert.That(item.Quality, Is.EqualTo(0));
        }
    }
}
