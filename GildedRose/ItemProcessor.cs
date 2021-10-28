using System;
namespace GildedRose
{
    public class ItemProcessor
    {
        public const string AgedBrie = "Aged Brie";
        public const string Backstage = "Backstage passes to a TAFKAL80ETC concert";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        public const string Conjured = "Conjured Mana Cake";

        public virtual void UpdateItemQuality(Item Item)
        {           
        }
        public static bool IsUnderLowestSellInValue(Item Item) => Item.SellIn < 0;
        public static bool IsUnderHighestQualityValue(Item Item) => Item.Quality < 50;
        public static bool IsAboveLowestQualityValue(Item Item) => Item.Quality > 0;

        public static ItemProcessor GetInstanceFor(Item item)
        {
            switch (item.Name)
            {
                case AgedBrie:
                    return new AgedBrieProcessor(item);

                case Backstage:
                    return new BackstageProcessor(item);

                case Sulfuras:
                    return new SulfurasProcessor(item);

                case Conjured:
                    return new ConjuredProcessor(item);

                default:
                    return new DefaultItemProcessor(item);
            }
        }
    }
}
