using Microsoft.Xna.Framework.Content;

namespace TankWars.Game.Data
{
    class Item
    {
        int value;
        int price;
        int level;

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
    }
}
