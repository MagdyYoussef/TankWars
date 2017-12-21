using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.MainMenuButtons
{
    class CreditsButton : TextureButton
    {
        public CreditsButton()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(300, 410));
            NormalPath = @"Screens/MainMenuScreen/Buttons/CreditsNormal";
            HighlightedPath = @"Screens/MainMenuScreen/Buttons/CreditsHighlighted";
        }

        public override void doClickedProcess()
        {
            EngineGame.screenManager.SetScreen(new LoadingScreen(new CreditsScreen()));
            base.doClickedProcess();
        }
    }
}