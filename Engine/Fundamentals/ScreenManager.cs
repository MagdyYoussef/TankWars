namespace Engine
{
    /// <summary>
    /// The screen class used by the ScreenManager.
    /// User should override Initialize, LoadContent, Draw, and Update.
    /// </summary>
    public class Screen : GameObject
    {
    }

    /// <summary>
    /// Handles all the screen functionality internally.
    /// </summary>
    public class ScreenManager
    {
        Screen m_CurrentScreen;

        /// <summary>
        /// Returns the current screen handled by the manager.
        /// </summary>
        public Screen CurrentScreen
        {
            get { return m_CurrentScreen; }
        }

        /// <summary>
        /// Changes the current screen.
        /// </summary>
        /// <param name="NextScreen">Next screen to be handled.</param>
        public void SetScreen(Screen NextScreen)
        {
            m_CurrentScreen = NextScreen;
            m_CurrentScreen.Initialize();
            m_CurrentScreen.LoadContent();
        }

        public virtual void Update()
        {
            m_CurrentScreen.Update();
        }

        public virtual void Draw()
        {
            m_CurrentScreen.Draw();
        }
    }
}
