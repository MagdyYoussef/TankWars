using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens
{
    class CreditsScreen : Screen
    {
        public override void Initialize()
        {
            TextureWrapper BackGround = new TextureWrapper(new WrapperState(0, 1, 0, Vector2.Zero, Color.White, Vector2.Zero), @"Screens/CreditsScreen/CreditsScreenBackGround");

            AddtoList(BackGround);
            AddtoList(new CreditsButtons.BackButton());
            base.Initialize();
        }
    }
}
