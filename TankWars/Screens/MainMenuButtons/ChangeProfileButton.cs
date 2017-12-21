using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.MainMenuButtons
{
    class ChangeProfileButton : TextureButton
    {
        public ChangeProfileButton()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(300, 480));
            NormalPath = @"Screens/MainMenuScreen/Buttons/ChangeProfileNormal";
            HighlightedPath = @"Screens/MainMenuScreen/Buttons/ChangeProfileHighlighted";
        }

        public override void doClickedProcess()
        {
            EngineGame.screenManager.SetScreen(new LoadingScreen(new ProfileScreen()));
            base.doClickedProcess();
        }
    }
}