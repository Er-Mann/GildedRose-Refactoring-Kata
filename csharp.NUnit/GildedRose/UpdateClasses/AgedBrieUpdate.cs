using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class AgedBrieUpdate : IUpdate
    {
        public void Update(Item item)
        {
            item.SellIn--;

            int qualityIncreaseAmount = (item.SellIn < 0) ? 2 : 1;
            item.Quality += qualityIncreaseAmount;
            if (item.Quality >= 50) item.Quality = 50;
        }
    }
}
