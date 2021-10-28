using System;
namespace GildedRose
{
    public class BackstageProcessor : ItemProcessor
    {
        private readonly Item _item;
        public BackstageProcessor(Item item)
        {
            _item = item;
        }

        public override void UpdateItemQuality(Item item)
        {          
            _item.SellIn--;

            if (IsUnderLowestSellInValue(_item))
            {               
                _item.Quality -= _item.Quality;                
            }
            else if (_item.SellIn < 10)
            {
                _item.Quality +=2;
            }
            else if (_item.SellIn < 5)
            {
                _item.Quality +=3;
            }                    
            else _item.Quality +=1;

            _item.Quality = IsUnderHighestQualityValue(_item) ? _item.Quality : 50;
        }
    }
}
