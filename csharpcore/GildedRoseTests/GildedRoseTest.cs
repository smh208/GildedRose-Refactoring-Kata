using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{

    [Test]
    public void QualityIsNeverNegative()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 3, Quality = 0 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(2, items[0].SellIn);
        Assert.AreEqual(0, items[0].Quality);
    }

    [Test]
    public void SellInDateHasPassedAndQualityDegradesTwiceAsFast()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 10 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(8, items[0].Quality);
    }

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
    public void BackStageSellGreaterThan10And50Quality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 50 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(10, items[0].SellIn);
        Assert.AreEqual(50, items[0].Quality);
    }

    [Test]
    public void BackStageSellGreaterThan10AndLessThan50Quality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 40 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(10, items[0].SellIn);
        Assert.AreEqual(41, items[0].Quality);
    }

    [Test]
    public void BackStageSellLessThan10DaysAnd50Quality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 50 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(8, items[0].SellIn);
        Assert.AreEqual(50, items[0].Quality);

    }

    [Test]
    public void BackStageSellLessThan10DaysAndLessThan50Quality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 40 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(8, items[0].SellIn);
        Assert.AreEqual(42, items[0].Quality);

    }

    [Test]
    public void BackStageSellLessThan5DaysAnd50Quality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 50 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(3, items[0].SellIn);
        Assert.AreEqual(50, items[0].Quality);

    }

    [Test]
    public void BackStageSellGreaterThan5DaysAndLessThan50Quality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 45 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(5, items[0].SellIn);
        Assert.AreEqual(47, items[0].Quality);
    }

    [Test]
    public void BackStageSellLessThan5DaysAndLessThan50Quality()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 45 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(3, items[0].SellIn);
        Assert.AreEqual(48, items[0].Quality);
    }

    [Test]
    public void BackStageSellInPassedAndQualityIs0()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 45 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual(-1, items[0].SellIn);
        Assert.AreEqual(0, items[0].Quality);

    }

    //[Test]
    //public void ConjuredItemsDegradeTwiceAsFast()
    //{
    //    var items = new List<Item> { new Item { Name = "Conjured", SellIn = 5, Quality = 10 } };
    //    var app = new GildedRose(items);
    //    app.UpdateQuality();
    //    Assert.AreEqual(8, items[0].Quality);
    //}

    //[Test]
    //public void ConjuredItemQualityIsNeverNegative()
    //{
    //    var items = new List<Item> { new Item { Name = "Conjured", SellIn = 5, Quality = 0 } };
    //    var app = new GildedRose(items);
    //    app.UpdateQuality();
    //    Assert.AreEqual(0, items[0].Quality);
    //}

    //[Test]
    //public void ConjuredItemSellInDatePassAndDegradesTwiceAsFast()
    //{
    //    var items = new List<Item> { new Item { Name = "Conjured", SellIn = 0, Quality = 10 } };
    //    var app = new GildedRose(items);
    //    app.UpdateQuality();
    //    Assert.AreEqual(6, items[0].Quality);
    //}
}