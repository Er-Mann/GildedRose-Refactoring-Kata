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
    public class AgedBrieTests
    {
        [Test]
        public void AgedBrie_IncreasesInQuality_AsItGetsOlder()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 10, Quality = 25 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(9));
            Assert.That(item.Quality, Is.EqualTo(26)); // normal incease by 1
        }

        [Test]
        public void AgedBrie_QualityIncreasesTwice_AsSellInExpires()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 0, Quality = 25 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(-1));
            Assert.That(item.Quality, Is.EqualTo(27)); // +2 after expiration
        }

        [Test]
        public void AgedBrie_QualityDoesNotExceedFifty()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 };
            var app = new GildedRose(new List<Item> { item });

            app.UpdateQuality();

            Assert.That(item.SellIn, Is.EqualTo(1));
            Assert.That(item.Quality, Is.EqualTo(50)); // still capped
        }
    }
}