using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRoseKata;
using GildedRoseStrategy;

namespace GildedRose.Strategy
{
    public class UpdateQuality
    {
        private IStrategy _strategy;

        public UpdateQuality(IStrategy strategy)
        {
            _strategy=strategy;
        }

        public Item Update(Item item)
        {
            return _strategy.UpdateQuality(item);
        }
    }
}
