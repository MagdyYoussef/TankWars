using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.ProfileButtons
{
    class PreviousButton : TextureButton
    {
        public PreviousButton()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(290, 265));
            NormalPath = @"Screens/ProfileScreen/Buttons/PreviousNormal";
            HighlightedPath = @"Screens/ProfileScreen/Buttons/PreviousHighlighted";
        }

        public override void doClickedProcess()
        {
            ((ProfileScreen)EngineGame.screenManager.CurrentScreen).profileManager.MovePrevious();
            base.doClickedProcess();
        }
    }
}
