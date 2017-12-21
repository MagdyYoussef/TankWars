using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.MainMenuButtons
{
    class PlayButton : TextureButton
    {
        public PlayButton()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(300, 340));
            NormalPath = @"Screens/MainMenuScreen/Buttons/PlayNormal";
            HighlightedPath = @"Screens/MainMenuScreen/Buttons/PlayHighlighted";
        }

        public override void doClickedProcess()
        {
            EngineGame.screenManager.SetScreen(new LoadingScreen(new WorldScreen()));
            base.doClickedProcess();
        }
    }
}
