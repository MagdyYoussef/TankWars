using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.ProfileButtons
{
    class CreateNewButton : TextureButton
    {
        public CreateNewButton()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(515, 440));
            NormalPath = @"Screens/ProfileScreen/Buttons/CreateNewNormal";
            HighlightedPath = @"Screens/ProfileScreen/Buttons/CreateNewHighlighted";
        }

        public override void doClickedProcess()
        {
            ProfileScreen screen = (ProfileScreen)EngineGame.screenManager.CurrentScreen;
            if (screen.NewProfileName.Length > 0)
                screen.profileManager.CreateNew(screen.NewProfileName);
            base.doClickedProcess();
        }
    }
}
