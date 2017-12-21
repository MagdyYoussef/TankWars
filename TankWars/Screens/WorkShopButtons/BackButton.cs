using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.WorkShopButtons
{
    class BackButton : TextureButton
    {
        public override void Initialize()
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, new Vector2(600, 550));
            NormalPath = @"Screens/WorkShopScreen/Buttons/BackNormal";
            HighlightedPath = @"Screens/WorkShopScreen/Buttons/BackHighlighted";

            base.Initialize();
        }

        public override void doClickedProcess()
        {
            EngineGame.screenManager.SetScreen(new LoadingScreen(new WorldScreen()));
            base.doClickedProcess();
        }
    }
}
