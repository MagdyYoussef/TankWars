using Engine;
using TankWars.Managers;
using System;

namespace TankWars.Game
{
    class GameState
    {
        static Profile m_CurrentProfile;
        static ItemsManager m_itemsManager;

        public static ItemsManager itemsManager
        {
            get { return m_itemsManager; }
            set { m_itemsManager = value; }
        }

        public static Profile CurrentProfile
        {
            get { return m_CurrentProfile; }
            set { m_CurrentProfile = value; }
        }

        public static void LoadContent()
        {
            m_itemsManager = (ItemsManager)XmlManager.ReadFromXml(@"Content/Data/Items.xml");
        }
    }
}
