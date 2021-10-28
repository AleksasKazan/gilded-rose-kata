using System;
namespace GildedRose
{
    public class DefaultItemProcessor : ItemProcessor
    {
        private readonly Item _item;
        public DefaultItemProcessor(Item item)
        {
            _item = item;
        }

        public override void UpdateItemQuality(Item item)
        {
            _item.SellIn--;

            if (IsUnderLowestSellInValue(_item))
            {
                _item.Quality -= 2;
            }
            else 
                _item.Quality--;

            _item.Quality = IsAboveLowestQualityValue(_item) ? _item.Quality : 0;
        }
    }
}
