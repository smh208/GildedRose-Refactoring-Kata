using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using GildedRoseKata;
using GildedRoseStrategy;

namespace GildedRose.Strategy
{
    public class AgedBrie:IStrategy
    {
        public Item UpdateQuality(Item item)
        {
            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
                
            }
            item.SellIn = item.SellIn - 1;
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

            }
            
            return item;
        }
    }
}
