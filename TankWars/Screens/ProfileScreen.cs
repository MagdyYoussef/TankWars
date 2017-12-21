using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TankWars.Managers;

namespace TankWars.Screens
{
    class ProfileScreen : Screen
    {
        ProfileManager m_profileManager;
        TextWrapper ProfileDescriptionWrapper, NewProfileWrapper;
        string ProfileDescriptionString, NewProfileString;
        int NewProfileStringMaxLength = 410;

        Keys[] AlphaKeys = {
            Keys.A , Keys.B , Keys.C , Keys.D , Keys.E , Keys.F , Keys.G , Keys.H , Keys.I , Keys.J , Keys.K , Keys.L , Keys.M ,
            Keys.N , Keys.O , Keys.P , Keys.Q , Keys.R , Keys.S , Keys.T ,  Keys.U , Keys.V , Keys.W , Keys.X , Keys.Y , Keys.Z };

        public ProfileManager profileManager
        {
            get { return m_profileManager; }
        }

        public string NewProfileName
        {
            get { return NewProfileString; }
        }

        public ProfileScreen()
        {
        }

        public override void Initialize()
        {
            ProfileDescriptionString = "";
            NewProfileString = "";

            m_profileManager = new ProfileManager();

            ProfileDescriptionWrapper = new TextWrapper(new WrapperState(0, 1, 0, Vector2.Zero, Color.Black, new Vector2(65, 190)), @"Fonts/Normal", "");
            NewProfileWrapper = new TextWrapper(new WrapperState(0, 1, 0, Vector2.Zero, Color.Black, new Vector2(70, 450)), @"Fonts/Normal", "");

            TextureWrapper BackGround = new TextureWrapper(new WrapperState(0, 1, 0, Vector2.Zero, Color.White, Vector2.Zero), @"Screens/ProfileScreen/ProfileBackGround");

            AddtoList(BackGround);
            AddtoList(ProfileDescriptionWrapper);
            AddtoList(NewProfileWrapper);

            AddtoList(new ProfileButtons.NextButton());
            AddtoList(new ProfileButtons.PreviousButton());
            AddtoList(new ProfileButtons.CreateNewButton());
            AddtoList(new ProfileButtons.LoadButton());
            AddtoList(new ProfileButtons.DeleteButton());

            base.Initialize();
        }

        public override void Update()
        {
            if (profileManager.Count == 0) ProfileDescriptionString = "No Profiles Curruntly";
            else ProfileDescriptionString = profileManager.CurrentProfile.Name;

            UpdateNewProfileString();
            
            NewProfileWrapper.Text = NewProfileString;
            ProfileDescriptionWrapper.Text = ProfileDescriptionString;
            
            base.Update();
        }

        private void UpdateNewProfileString()
        {
            if (NewProfileWrapper.MeasureString(NewProfileString) < NewProfileStringMaxLength)
            {
                foreach (Keys key in AlphaKeys)
                {
                    if (EngineGame.inputManager.IsKeyPressed(key))
                    {
                        if (EngineGame.inputManager.IsKeyDown(Keys.RightShift) || EngineGame.inputManager.IsKeyDown(Keys.LeftShift))
                            NewProfileString += key.ToString();
                        else
                            NewProfileString += key.ToString().ToLower();
                    }
                }
                if (EngineGame.inputManager.IsKeyPressed(Keys.Space))
                    NewProfileString += " ";
            }
            if (EngineGame.inputManager.IsKeyPressed(Keys.Back) && NewProfileString.Length > 0)
                NewProfileString = NewProfileString.Substring(0, NewProfileString.Length - 1);
        }
    }
}
