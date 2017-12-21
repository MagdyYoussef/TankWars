using System.Collections.Generic;
using Engine;
using TankWars.Game;
using TankWars.Screens;

namespace TankWars.Managers
{
    class ProfileManager
    {
        List<Profile> Profiles;
        int CurrentPosition;

        public int Count
        {
            get { return Profiles.Count; }
        }
        public Profile CurrentProfile
        {
            get { return Profiles[CurrentPosition]; }
        }

        public ProfileManager()
        {
            ReadFile();
            CurrentPosition = 0;
        }

        public void ReadFile()
        {
            Profiles = (List<Profile>)XmlManager.ReadFromXml(@"Content/Data/Profiles.xml");
        }
        public void SaveFile()
        {
            XmlManager.WriteToXml(Profiles, @"Content/Data/Profiles.xml");
        }

        public void MoveNext()
        {
            if (CurrentPosition + 1 < Profiles.Count)
                CurrentPosition++;
        }
        public void MovePrevious()
        {
            if (CurrentPosition > 0)
                CurrentPosition--;
        }

        public void LoadProfile()
        {
            if (Profiles.Count > 0)
            {
                GameState.CurrentProfile = Profiles[CurrentPosition];
            }
        }
        public void DeleteProfile()
        {
            if (Profiles.Count > 0)
            {
                Profiles.RemoveAt(CurrentPosition);
                CurrentPosition = 0;
            }
        }
        public void CreateNew(string ProfileName)
        {
            Profile NewProfile = new Profile();
            NewProfile.Name = ProfileName;
            NewProfile.Coins = 0;
            NewProfile.Level = 1;
            NewProfile.MachineGun = GameState.itemsManager.MachineGun.Upgrade1;
            Profiles.Add(NewProfile);
            CurrentPosition = Profiles.Count - 1;
        }
    }
}
