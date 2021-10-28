using System;
namespace GildedRose
{
    public class ConjuredProcessor : ItemProcessor
    {
        private readonly Item _item;
        public ConjuredProcessor(Item item)
        {
            _item = item;
        }

        public override void UpdateItemQuality(Item item)
        {
            _item.SellIn--;

            if (IsUnderLowestSellInValue(_item))
            {
                _item.Quality -= 4;
            }
            else
                _item.Quality -= 2;

            _item.Quality = IsAboveLowestQualityValue(_item) ? _item.Quality : 0;
        }
    }
}
