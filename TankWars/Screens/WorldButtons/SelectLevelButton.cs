using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TankWars.Screens.WorldButtons
{
    class SelectLevelButton : TextureButton
    {
        int Level;
        string Name;
        bool canPlay;

        public SelectLevelButton(int Level, Vector2 Position, string Name, bool canPlay)
        {
            this.Level = Level;
            this.Name = Name;
            this.canPlay = canPlay;
            State = new WrapperState(0, 1, 0, Vector2.Zero, Color.White, Position);
            if (canPlay)
            {
                NormalPath = @"Screens/WorldScreen/Buttons/LevelCanPlayNormal";
                HighlightedPath = @"Screens/WorldScreen/Buttons/LevelCanPlayHighlighted";
            }
            else
            {
                NormalPath = @"Screens/WorldScreen/Buttons/LevelCannotPlayNormal";
                HighlightedPath = @"Screens/WorldScreen/Buttons/LevelCannotPlayHighlighted";
            }
        }

        public override void doClickedProcess()
        {
            if (canPlay)
                EngineGame.screenManager.SetScreen(new LoadingScreen(new GameScreen(Level)));
            base.doClickedProcess();
        }

        public override void doHoveredProcess()
        {
            ((WorldScreen)EngineGame.screenManager.CurrentScreen).DisplayText = "Level " + Level + ": " + Name;
            base.doHoveredProcess();
        }
    }
}
