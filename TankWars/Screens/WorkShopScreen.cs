using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens
{
    class WorkShopScreen : Screen
    {
        public override void Initialize()
        {
            TextureWrapper BackGround = new TextureWrapper(new WrapperState(0, 1, 0, Vector2.Zero, Color.White, Vector2.Zero), @"Screens/WorkShopScreen/WorkShopBackGround");

            AddtoList(BackGround);
            AddtoList(new WorkShopButtons.BackButton());

            base.Initialize();
        }
    }
}
