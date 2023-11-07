using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRoseKata;

namespace GildedRoseStrategy
{
    public interface IStrategy
    {
        public Item UpdateQuality(Item item);
    }
}
