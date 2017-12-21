using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.CreditsButtons
{
    class BackButton : TextureButton
    {
        public override void Initialize()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(600, 550));
            NormalPath = @"Screens/CreditsScreen/Buttons/BackNormal";
            HighlightedPath = @"Screens/CreditsScreen/Buttons/BackHighlighted";

            base.Initialize();
        }

        public override void doClickedProcess()
        {
            EngineGame.screenManager.SetScreen(new LoadingScreen(new MainMenuScreen()));
            base.doClickedProcess();
        }
    }
}
