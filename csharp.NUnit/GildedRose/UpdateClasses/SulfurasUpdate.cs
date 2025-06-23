using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class SulfurasUpdate : IUpdate
    {
        public void Update(Item item)
        { 
            item.Quality = 80;      
        }
    }
}
