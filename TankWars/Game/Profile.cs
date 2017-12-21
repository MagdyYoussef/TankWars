using TankWars.Game.Data;

namespace TankWars.Game
{
    class Profile
    {
        string name;
        int coins;
        int level;

        Item machineGun;
        Item canon;
        Item laser;
        Item bodyArmor;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Coins
        {
            get { return coins; }
            set { coins = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Item MachineGun
        {
            get { return machineGun; }
            set { machineGun = value; }
        }

        public Item Canon
        {
            get { return canon; }
            set { canon = value; }
        }

        public Item Laser
        {
            get { return laser; }
            set { laser = value; }
        }

        public Item BodyArmor
        {
            get { return bodyArmor; }
            set { bodyArmor = value; }
        }

        public Profile()
        {
        }
    }
}
