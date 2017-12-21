using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TankWars.Game;

namespace TankWars.Screens
{
    class MainMenuScreen : Screen
    {
        public override void Initialize()
        {
            TextureWrapper BackGround = new TextureWrapper(new WrapperState(0, 1, 0, Vector2.Zero, Color.White, Vector2.Zero), @"Screens/MainMenuScreen/MainMenuBackGround");
            TextWrapper Profile = new TextWrapper(new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(10, 600)), @"Fonts/Normal", "Current Profile: " + GameState.CurrentProfile.Name);

            AddtoList(BackGround);
            AddtoList(Profile);
            AddtoList(new MainMenuButtons.PlayButton());
            AddtoList(new MainMenuButtons.CreditsButton());
            AddtoList(new MainMenuButtons.ChangeProfileButton());
            AddtoList(new MainMenuButtons.ExitButton());

            base.Initialize();
        }
    }
}
