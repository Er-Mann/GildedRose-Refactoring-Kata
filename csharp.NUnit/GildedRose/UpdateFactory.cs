using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public static class UpdateFactory
    {
        public static IUpdate GetUpdate(Item item)
        {
            if (item.Name == "Aged Brie")
                return new AgedBrieUpdate();
            if (item.Name == "Sulfuras, Hand of Ragnaros")
                return new SulfurasUpdate();
            if (item.Name.Contains("Backstage"))
                return new BackstagePassesUpdate();
            if (item.Name.Contains("Conjured"))
                return new ConjuredItemUpdate();

            return new NormalItemUpdate();
        }
    }
}

