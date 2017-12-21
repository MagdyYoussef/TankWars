using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.ProfileButtons
{
    class NextButton : TextureButton
    {
        public NextButton()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(55, 265));
            NormalPath = @"Screens/ProfileScreen/Buttons/NextNormal";
            HighlightedPath = @"Screens/ProfileScreen/Buttons/NextHighlighted";
        }

        public override void doClickedProcess()
        {
            ((ProfileScreen)EngineGame.screenManager.CurrentScreen).profileManager.MoveNext();
            base.doClickedProcess();
        }
    }
}
