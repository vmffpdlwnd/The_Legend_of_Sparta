using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Sparta
{
    public class Item
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public string Description { get; set; }
        public bool IsEquipped { get; set; }
        public ItemType Type { get; set; }
        public int Price { get; set; }  
        public bool IsPurchased { get; set; }
        public bool IsBasicItem { get; set; }
    }
    public enum ItemType
    {
        Spear, // 창
        Sword, // 검
        Axe,   // 도끼
        Wand,  // 지팡이
        Armor, // 방어구
        Cloak  // 망토
    }
}
