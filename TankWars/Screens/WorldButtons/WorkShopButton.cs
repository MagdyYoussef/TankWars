using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.WorldButtons
{
    class WorkShopButton : TextureButton
    {
        public WorkShopButton(Vector2 Position)
        {
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, Position);
            NormalPath = @"Screens/WorldScreen/Buttons/WorkShopNormal";
            HighlightedPath = @"Screens/WorldScreen/Buttons/WorkShopHighlighted";
        }

        public override void doClickedProcess()
        {
            EngineGame.screenManager.SetScreen(new LoadingScreen(new WorkShopScreen()));
            base.doClickedProcess();
        }

        public override void doHoveredProcess()
        {
            ((WorldScreen)EngineGame.screenManager.CurrentScreen).DisplayText = "WorkShop : USA";
            base.doHoveredProcess();
        }
    }
}
