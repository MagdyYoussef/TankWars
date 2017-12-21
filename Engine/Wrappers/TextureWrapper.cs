using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Engine
{
    /// <summary>
    /// A Texture wrapper that represents images to be drawn on screen.
    /// </summary>
    public class TextureWrapper : GameObject
    {
        Texture2D Texture;
        WrapperState State;
        string FilePath;

        public Vector2 Position
        {
            get { return State.Position; }
        }
        public int Width
        {
            get { return Texture.Width; }
        }
        public int Height
        {
            get { return Texture.Height; }
        }

        /// <summary>
        /// Creates a new instance of the texture wrapper.
        /// </summary>
        /// <param name="State">State of the texture.</param>
        /// <param name="FilePath">File path of the image file.</param>
        public TextureWrapper(WrapperState State, string FilePath)
        {
            this.State = State;
            this.FilePath = FilePath;
        }

        public override void LoadContent()
        {
            Texture = EngineGame.contentManager.Load<Texture2D>(FilePath);
            base.LoadContent();
        }
        public override void Draw()
        {
            EngineGame.spriteBatch.Draw(Texture, State.Position, null, State.DrawColor, State.Rotation,
                State.Origin, State.Scale, SpriteEffects.None, State.DrawOrder);
            base.Draw();
        }

        /// <summary>
        /// Draws a certain percentage from 0.0 to 1.0 in width.
        /// </summary>
        /// <param name="Percentage">Percentage ranging from 0.0 to 1.0.</param>
        public void DrawPercentage(float Percentage)
        {
            EngineGame.spriteBatch.Draw(Texture, State.Position,
                new Rectangle(0, 0, (int)((float)Texture.Width * Percentage), Texture.Height),
                State.DrawColor, State.Rotation,
                State.Origin, State.Scale, SpriteEffects.None, State.DrawOrder);
            base.Draw();
        }
    }
}
