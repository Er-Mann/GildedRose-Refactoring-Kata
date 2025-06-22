using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    internal class BackstagePassesUpdate : IUpdate
    {
        public void Update(Item item)
        {
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality = 0; // After the concert, quality drops to 0
                return;
            } else if (item.SellIn > 0)
            {
                int qualityIncreaseAmount = 1; // Normal increase
                if (item.SellIn <= 10)
                {
                    qualityIncreaseAmount++; // again +1 if 10 days or less
                }
                if (item.SellIn <= 5)
                {
                    qualityIncreaseAmount++; // again +1 if 5 days or less
                }
                item.Quality += qualityIncreaseAmount;
            }

            if (item.Quality >= 50) item.Quality = 50;
        }
    }
}
*
