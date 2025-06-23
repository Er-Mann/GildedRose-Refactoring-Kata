using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class ConjuredItemUpdate : IUpdate
    {
        public void Update(Item item)
        {
            item.SellIn--;

            int degradeAmount = (item.SellIn < 0) ? 4 : 2;
            item.Quality -= degradeAmount;
            if (item.Quality < 0) item.Quality = 0;
        }
    }
}
