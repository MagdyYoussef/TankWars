using Microsoft.Xna.Framework;

namespace Engine
{
    /// <summary>
    /// User should override this class and override doProcess() function to do desired task.
    /// </summary>
    public abstract class TextureButton : GameObject
    {
        protected string NormalPath, HighlightedPath;
        protected WrapperState State;
        TextureWrapper NormalTexture, HighlightedTexture;
        TextureWrapper CurrentTexture;

        public override void Initialize()
        {
            NormalTexture = new TextureWrapper(State, NormalPath);
            HighlightedTexture = new TextureWrapper(State, HighlightedPath);
            CurrentTexture = NormalTexture;
            base.Initialize();
        }

        public override void LoadContent()
        {
            NormalTexture.LoadContent();
            HighlightedTexture.LoadContent();
            base.LoadContent();
        }

        public override void Draw()
        {
            CurrentTexture.Draw();
            base.Draw();
        }

        /// <summary>
        /// Returns whether the mouse hoveres over the texture.
        /// </summary>
        public bool IsHovered()
        {
            Point MousePosition = EngineGame.inputManager.GetMousePosition();
            Vector2 TexturePosition = CurrentTexture.Position;
            return (TexturePosition.X < MousePosition.X && MousePosition.X < TexturePosition.X + CurrentTexture.Width &&
                TexturePosition.Y < MousePosition.Y && MousePosition.Y < TexturePosition.Y + CurrentTexture.Height);
        }
        /// <summary>
        /// Returns whether the mouse presses the texture.
        /// </summary>
        /// <returns></returns>
        public bool IsPressed()
        {
            return (EngineGame.inputManager.IsLeftMouseButtonClicked() && IsHovered());
        }

        public override void Update()
        {
            HandleUserInput();
            base.Update();
        }

        void HandleUserInput()
        {
            if (IsPressed())
                doClickedProcess();
            else if (IsHovered())
            {
                CurrentTexture = HighlightedTexture;
                doHoveredProcess();
            }
            else
                CurrentTexture = NormalTexture;
        }

        /// <summary>
        /// The functionality that the button does when clicked.
        /// </summary>
        public virtual void doClickedProcess()
        {
        }


        /// <summary>
        /// The functionality that the button does when hovered.
        /// </summary>
        public virtual void doHoveredProcess()
        {
        }
    }
}
