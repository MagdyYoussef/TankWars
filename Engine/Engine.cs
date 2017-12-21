using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Engine
{
    /// <summary>
    /// This class is intended to be used in every game as an objrct.
    /// User should create a new object and pass the initial screen to the constructor then call Run().
    /// User can use graphics, spriteBatch, and screenManager in any part of the game.
    /// </summary>
    public class EngineGame : Microsoft.Xna.Framework.Game
    {
        static GraphicsDeviceManager m_graphics;
        static SpriteBatch m_spriteBatch;
        static ScreenManager m_screenManager;
        static InputManager m_inputManager;
        static ContentManager m_content;

        static bool isExiting = false;

        Screen InitialScreen;

        /// <summary>
        /// The Handle to the Screen which contains XNA original functionality.
        /// </summary>
        public static GraphicsDeviceManager graphics
        {
            get { return m_graphics; }
        }
        /// <summary>
        /// The XNA SpriteBatch used to draw things over the screen.
        /// </summary>
        public static SpriteBatch spriteBatch
        {
            get { return m_spriteBatch; }
        }
        /// <summary>
        /// The screen manager that is used to change screens at runtime.
        /// </summary>
        public static ScreenManager screenManager
        {
            get { return m_screenManager; }
        }
        /// <summary>
        /// The contentManager used to load resources into XNA variables.
        /// </summary>
        public static ContentManager contentManager
        {
            get { return m_content; }
        }
        /// <summary>
        /// The input manager contains mouse and keyboard details (auto Updated).
        /// </summary>
        public static InputManager inputManager
        {
            get { return m_inputManager; }
        }

        /// <summary>
        /// Creates a new Instance of the Engine Game.
        /// </summary>
        /// <param name="InitialScreen">Initial Screen to be displayed first.</param>
        public EngineGame(Screen InitialScreen)
        {
            this.InitialScreen = InitialScreen;

            m_graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            m_content = Content;

            m_screenManager = new ScreenManager();
            m_inputManager = new InputManager();

        }

        protected override void Initialize()
        {
            base.Initialize();            
        }

        protected override void LoadContent()
        {
            m_spriteBatch = new SpriteBatch(GraphicsDevice);
            m_screenManager.SetScreen(InitialScreen);
        }

        protected override void Update(GameTime gameTime)
        {
            if (isExiting)
                Exit();

            inputManager.Update();
            screenManager.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();
            screenManager.Draw();
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public static void ExitGame()
        {
            isExiting = true;
        }
    }
}