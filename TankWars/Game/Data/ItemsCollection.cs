using Microsoft.Xna.Framework.Content;

namespace TankWars.Game.Data
{
    class ItemsCollection
    {
        string name;
        Item upgrade1;
        Item upgrade2;
        Item upgrade3;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Item Upgrade1
        {
            get { return upgrade1; }
            set { upgrade1 = value; }
        }
        public Item Upgrade2
        {
            get { return upgrade2; }
            set { upgrade2 = value; }
        }
        public Item Upgrade3
        {
            get { return upgrade3; }
            set { upgrade3 = value; }
        }
    }
}
