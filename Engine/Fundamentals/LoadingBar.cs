namespace Engine
{
    /// <summary>
    /// Represents a loading bar that changes by a variable.
    /// </summary>
    public class LoadingBar : GameObject
    {
        TextureWrapper BackGround, Cover;
        float m_Percentage;

        /// <summary>
        /// Gets or sents the percentage from 0.0 to 1.0.
        /// </summary>
        public float Percentage
        {
            get { return m_Percentage; }
            set { m_Percentage = value; }
        }

        /// <summary>
        /// Constructs a new loading bar.
        /// </summary>
        /// <param name="State">State of the images.</param>
        /// <param name="BackGroundPath">Background image path.</param>
        /// <param name="CoverPath">Cover image path.</param>
        public LoadingBar(WrapperState State, string BackGroundPath, string CoverPath)
        {
            BackGround = new TextureWrapper(State, BackGroundPath);
            Cover = new TextureWrapper(State, CoverPath);
        }

        public override void LoadContent()
        {
            BackGround.LoadContent();
            Cover.LoadContent();
            base.LoadContent();
        }

        public override void Draw()
        {
            BackGround.DrawPercentage(Percentage);
            Cover.Draw();
            base.Draw();
        }
    }
}
