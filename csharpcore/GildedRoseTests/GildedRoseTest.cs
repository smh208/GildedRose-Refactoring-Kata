using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

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

    [Test]
    public void AgedBrieLessThanZeroHigherQuality()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -1, Quality = 45 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(47, items[0].Quality);
    }
    [Test]
    public void AgedBrieGreaterThanZeroSellInHigherQuality()
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

    [Test]
    public void SellByPassed()
    {
        //var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
        //var app = new GildedRose(items);
        //app.UpdateQuality();
        //Assert.AreEqual(1, items[0].SellIn);
    }
}