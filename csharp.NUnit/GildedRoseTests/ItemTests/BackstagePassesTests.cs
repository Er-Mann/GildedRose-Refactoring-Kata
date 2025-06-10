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
    public class BackstagePassesTests 
    {
        private const string PassName = "Backstage pass name";

        [Test]
        public void BackstagePasses_IncreaseBy1_WhenSellInAbove10()
        {
            var item = new Item { Name = PassName, SellIn = 15, Quality = 20 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(14));
            Assert.That(item.Quality, Is.EqualTo(21));
        }

        [Test]
        public void BackstagePasses_IncreaseBy2_WhenSellInBetween10And6()
        {
            var item = new Item { Name = PassName, SellIn = 10, Quality = 20 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(9));
            Assert.That(item.Quality, Is.EqualTo(22));
        }

        [Test]
        public void BackstagePasses_IncreaseBy3_WhenSellInBetween5And1()
        {
            var item = new Item { Name = PassName, SellIn = 5, Quality = 20 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(4));
            Assert.That(item.Quality, Is.EqualTo(23));
        }

        [Test]
        public void BackstagePasses_QualityDropsToZero_AfterConcert()
        {
            var item = new Item { Name = PassName, SellIn = 0, Quality = 20 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(-1));
            Assert.That(item.Quality, Is.EqualTo(0));
        }

        [Test]
        public void BackstagePasses_QualityNeverExceedsFifty()
        {
            var item = new Item { Name = PassName, SellIn = 5, Quality = 49 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(4));
            Assert.That(item.Quality, Is.EqualTo(50));
        }
    }
}