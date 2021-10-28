using System;
namespace GildedRose
{
    public class SulfurasProcessor : ItemProcessor
    {
        private readonly Item _item;
        public SulfurasProcessor(Item item)
        {
            _item = item;
        }

        public override void UpdateItemQuality(Item item)
        {            
        }
    }
}
