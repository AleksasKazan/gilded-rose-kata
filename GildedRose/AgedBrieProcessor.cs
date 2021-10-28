using System;
namespace GildedRose
{
    public class AgedBrieProcessor : ItemProcessor
    {
        private readonly Item _item;
        public AgedBrieProcessor(Item item)
        {
            _item = item;
        }
        public override void UpdateItemQuality(Item item)
        {                     
            _item.SellIn--;

            if (IsUnderLowestSellInValue(_item))
            {
                _item.Quality += 2;
            }
            else
            {
                _item.Quality++;
            }

            _item.Quality = IsUnderHighestQualityValue(_item) ? _item.Quality : 50;
        }
    }
}
