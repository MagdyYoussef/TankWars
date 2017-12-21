using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens
{
    class LoadingScreen : Screen
    {
        Screen NextScreen;
        Timer ScreenTimer;
        LoadingBar loadingBar;

        public LoadingScreen(Screen NextScreen)
        {
            this.NextScreen = NextScreen;
        }

        public override void Initialize()
        {
            ScreenTimer = new Timer(5);
            AddtoList(ScreenTimer);

            WrapperState State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, Vector2.Zero);
            loadingBar = new LoadingBar(State, @"Screens/LoadingScreen/LoadingBackGround", @"Screens/LoadingScreen/LoadingCover");
            AddtoList(loadingBar);

            base.Initialize();
        }

        public override void Update()
        {
            if (ScreenTimer.IsTimedOut())
            {
                loadingBar.Percentage += 0.05f;
            }
            if (loadingBar.Percentage > 1f)
            {
                EngineGame.screenManager.SetScreen(NextScreen);
            }
            base.Update();
        }
    }
}
