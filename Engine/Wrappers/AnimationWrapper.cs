using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Engine
{
    /// <summary>
    /// Used as a layer to animate a spritesheet that contains several frames.
    /// </summary>
    public class AnimationWrapper : GameObject
    {
        WrapperState State;
        string FilePath;
        Texture2D SpriteSheet;
        bool IsRunning;

        Timer FramesTimer;
        int FrameHeight, FrameWidth;
        Point currentFrame;
        int FramesPerRow, FramesPerColumn, TicksBetweenFrames;

        /// <summary>
        /// Makes a new AnimationWrapper.
        /// </summary>
        /// <param name="State">State of each internal frame to be drawn.</param>
        /// <param name="FilePath">File Path of the SpriteSheet.</param>
        /// <param name="FrameHeight">Frame Height in pixels.</param>
        /// <param name="FrameWidth">Frame Width in pixels.</param>
        /// <param name="TicksBetweenFrames">Ticks required to change frames.</param>
        public AnimationWrapper(WrapperState State, string FilePath, int FrameHeight, int FrameWidth, int TicksBetweenFrames)
        {
            this.State = State;
            this.FilePath = FilePath;
            this.FrameHeight = FrameHeight;
            this.FrameWidth = FrameWidth;
            this.TicksBetweenFrames = TicksBetweenFrames;
        }

        public override void Initialize()
        {
            FramesTimer = new Timer(TicksBetweenFrames);
            currentFrame = new Point(0, 0);
            IsRunning = true;
            base.Initialize();
        }

        public override void LoadContent()
        {
            SpriteSheet = EngineGame.contentManager.Load<Texture2D>(FilePath);
            FramesPerRow = SpriteSheet.Width / FrameWidth;
            FramesPerColumn = SpriteSheet.Height / FrameHeight;
            base.LoadContent();
        }

        public override void Draw()
        {
            EngineGame.spriteBatch.Draw(SpriteSheet, State.Position,
                new Rectangle ( currentFrame.X * FrameWidth,
                    currentFrame.Y*FrameHeight,
                    FrameWidth,FrameHeight),
                State.DrawColor, State.Rotation,
                State.Origin, State.Scale, SpriteEffects.None, State.DrawOrder);
            base.Draw();
        }

        public override void Update()
        {
            if (IsRunning)
            {
                FramesTimer.Update();
                if (FramesTimer.IsTimedOut())
                {
                    currentFrame.X++;
                    if (currentFrame.X > FramesPerRow)
                    {
                        currentFrame.X = 0;
                        currentFrame.Y++;
                    }
                    if (currentFrame.Y > FramesPerColumn)
                    {
                        currentFrame.Y = 0;
                    }
                }
            }
            base.Update();
        }

        /// <summary>
        /// Continues the frame animation.
        /// </summary>
        public void Continue()
        {
            IsRunning = true;
        }
        /// <summary>
        /// Pauses the frame animation.
        /// </summary>
        public void Pause()
        {
            IsRunning = false;
        }
    }
}
