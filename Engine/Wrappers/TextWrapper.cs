using Microsoft.Xna.Framework.Graphics;

namespace Engine
{
    public class TextWrapper : GameObject
    {
        protected SpriteFont spriteFont;
        protected string text;
        protected WrapperState State;
        protected string FilePath;
        protected int Width;

        public string Text
        {
            get { return text; }
            set
            {
                if (Width > 0) text = ParseText(value);
                else text = value;
            }
        }

        /// <summary>
        /// Creates a new instance of the text wrapper.
        /// </summary>
        /// <param name="State">State of text to be drawn.</param>
        /// <param name="FilePath">File path of the spritefont object.</param>
        /// <param name="Text">Text to be drawn on the screen.</param>
        public TextWrapper(WrapperState State, string FilePath, string Text)
        {
            this.State = State;
            this.FilePath = FilePath;
            this.text = Text;
            this.Width = -1;
        }
        /// <summary>
        /// Creates a new instance of the text wrapper.
        /// </summary>
        /// <param name="State">State of text to be drawn.</param>
        /// <param name="FilePath">File path of the spritefont object.</param>
        /// <param name="Text">Text to be drawn on the screen.</param>
        /// <param name="Width">Width in pixels of the box containing the text.</param>
        public TextWrapper(WrapperState State, string FilePath, string Text, int Width)
        {
            this.State = State;
            this.FilePath = FilePath;
            this.text = Text;
            this.Width = Width;
        }

        public override void LoadContent()
        {
            spriteFont = EngineGame.contentManager.Load<SpriteFont>(FilePath);
            if ( Width > 0 )
                text = ParseText(text);
            base.LoadContent();
        }
        public override void Draw()
        {
            EngineGame.spriteBatch.DrawString(spriteFont, text, State.Position, State.DrawColor, State.Rotation,
                State.Origin, State.Scale, SpriteEffects.None, State.DrawOrder);
            base.Draw();
        }
        string ParseText(string text)
        {
            string line = "";
            string returnString = "";
            string[] wordArray = text.Split(' ');

            foreach (string word in wordArray)
            {
                if (MeasureString(line + word) > Width)
                {
                    returnString = returnString + line + '\n';
                    line = "";
                }
                line = line + word + ' ';
            }
            return returnString + line;
        }

        public int MeasureString(string String)
        {
            return (int) spriteFont.MeasureString(String).Length();
        }
    }
}
