using TankWars.Game.Data;
using Microsoft.Xna.Framework.Content;

namespace TankWars.Managers
{
    class ItemsManager
    {
        ItemsCollection machineGun;
        ItemsCollection canon;
        ItemsCollection laser;
        ItemsCollection armor;

        public ItemsCollection MachineGun
        {
            get { return machineGun; }
            set { machineGun = value; }
        }
        public ItemsCollection Canon
        {
            get { return canon; }
            set { canon = value; }
        }
        public ItemsCollection Laser
        {
            get { return laser; }
            set { laser = value; }
        }
        public ItemsCollection Armor
        {
            get { return armor; }
            set { armor = value; }
        }
    }
}
