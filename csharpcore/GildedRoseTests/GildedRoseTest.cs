using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{

    [Test]
    public void AgedBrieLessThanZeroHigherQuality()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -1, Quality = 45 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(47, items[0].Quality);
    }
    [Test]
    public void AgedBrieGreaterThanZeroSellInWithOneQualityIncrease()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 45 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(1, items[0].SellIn);
        Assert.AreEqual(46, items[0].Quality);
    }
    [Test]
    public void AgedBrieQuality50()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(1, items[0].SellIn);
    }

    [Test] public void SulfurasItemNeverSellNeverAged()
    {
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 2, Quality = 50 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(2, items[0].SellIn);
        Assert.AreEqual(50, items[0].Quality);

    }
    
    [Test]
    public void BackStageSellLessThan11DaysAnd50Quality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 50 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(1, items[0].SellIn);

    }

    [Test]
    public void BackStageSellGreaterThan6DaysAndLessThan50Quality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 7, Quality = 45 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(6, items[0].SellIn);
        Assert.AreEqual(47, items[0].Quality);

    }

    [Test]
    public void BackStageSellLessThan6DaysAndLessThan50Quality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 45 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(1, items[0].SellIn);
        Assert.AreEqual(48, items[0].Quality);

    }
}