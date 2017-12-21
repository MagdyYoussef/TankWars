using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.MainMenuButtons
{
    class ExitButton : TextureButton
    {
        public ExitButton()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(300, 550));
            NormalPath = @"Screens/MainMenuScreen/Buttons/ExitNormal";
            HighlightedPath = @"Screens/MainMenuScreen/Buttons/ExitHighlighted";
        }

        public override void doClickedProcess()
        {
            EngineGame.ExitGame();
            base.doClickedProcess();
        }
    }
}