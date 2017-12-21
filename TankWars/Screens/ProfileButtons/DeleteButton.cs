using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.ProfileButtons
{
    class DeleteButton : TextureButton
    {
        public DeleteButton()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(530, 190));
            NormalPath = @"Screens/ProfileScreen/Buttons/DeleteNormal";
            HighlightedPath = @"Screens/ProfileScreen/Buttons/DeleteHighlighted";
        }

        public override void doClickedProcess()
        {
            ((ProfileScreen)EngineGame.screenManager.CurrentScreen).profileManager.DeleteProfile();
            base.doClickedProcess();
        }
    }
}