using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TankWars.Game;

namespace TankWars.Screens.ProfileButtons
{
    class LoadButton : TextureButton
    {
        public LoadButton()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(530, 265));
            NormalPath = @"Screens/ProfileScreen/Buttons/LoadNormal";
            HighlightedPath = @"Screens/ProfileScreen/Buttons/LoadHighlighted";
        }

        public override void doClickedProcess()
        {
            ((ProfileScreen)EngineGame.screenManager.CurrentScreen).profileManager.LoadProfile();
            ((ProfileScreen)EngineGame.screenManager.CurrentScreen).profileManager.SaveFile();            
            EngineGame.screenManager.SetScreen(new LoadingScreen(new MainMenuScreen()));

            base.doClickedProcess();
        }
    }
}
