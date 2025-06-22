using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class NormalItemUpdate : IUpdate
    {
        public void Update(Item item)
        {
            item.SellIn--;

            int degradeAmount = (item.SellIn < 0) ? 2 : 1;
            item.Quality -= degradeAmount;
            if (item.Quality < 0) item.Quality = 0;
        }
    }
}
