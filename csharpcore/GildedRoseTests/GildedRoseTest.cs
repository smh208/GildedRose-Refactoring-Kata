using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace GildedRoseTests;

public class GildedRoseTest
{
    //[Test]
    //public void Foo()
    //{
    //    var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
    //    var app = new GildedRose(items);
    //    app.UpdateQuality();
    //    Assert.AreEqual("fixme", items[0].Name);
    //}

    // After each day SellIn and Quality decrease -1

    [Test]
    public void qualityDegradesTwiceAsFAst()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 2 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(0, items[0].Quality);
    }

    [Test]
    public void qualityIsNeverNegative()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 1, Quality = 0 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(0, items[0].Quality);
    }

    [Test]
    public void agedBrieIncreasesQuality()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(2, items[0].Quality);
    }

    [Test]
    public void qualityIsNeverGreaterThan50()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(50, items[0].Quality);
    }

    [Test]
    public void sulfrasNeverDecreasesInQuality()
    {
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 80 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(80, items[0].Quality);
        Assert.AreEqual(1, items[0].SellIn);
    }

    [Test]
    public void backstagePassesIncreasesInQuality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 1 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(2, items[0].Quality);
    }

    [Test]
    public void backstagePassesIncreasesQualityByTwo()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 1 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(3, items[0].Quality);
    }

    [Test]
    public void backstagePassesIncreasesQualityByThree()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 1 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(4, items[0].Quality);
    }

    [Test]
    public void backstagePassesQualityIsZero()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(0, items[0].Quality);
    }

    // New Test that needs updated code
    [Test]
    public void conjuredDegradesTwiceAsFast()
    {
        var items = new List<Item> { new Item { Name = "Conjured", SellIn = 1, Quality = 10 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(8, items[0].Quality);
    }
}
