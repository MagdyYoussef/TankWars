using Engine;
using TankWars.Game;
using TankWars.Screens;
using System.Collections.Generic;

namespace TankWars
{
    static class Program
    {
        static void Main()
        {
            EngineGame TankWars = new EngineGame(new LoadingScreen(new ProfileScreen()));
            TankWars.IsMouseVisible = true;
            EngineGame.graphics.PreferredBackBufferHeight = 640;
            EngineGame.graphics.PreferredBackBufferWidth = 800;

            GameState.LoadContent();
            TankWars.Run();
        }
    }
}

