using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Engine
{
    public class InputManager
    {
        MouseState prevMouseState, currentMouseState;
        KeyboardState prevKeyboardState, currentKeyboardState;

        public void Update()
        {
            prevMouseState = currentMouseState;
            currentMouseState = Mouse.GetState();

            prevKeyboardState = currentKeyboardState;
            currentKeyboardState = Keyboard.GetState();
        }
        public bool IsKeyDown(Keys key)
        {
            return currentKeyboardState.IsKeyDown(key);
        }
        public bool IsKeyUp(Keys key)
        {
            return currentKeyboardState.IsKeyUp(key);
        }
        public bool IsKeyPressed(Keys key)
        {
            return (prevKeyboardState.IsKeyUp(key) && currentKeyboardState.IsKeyDown(key));
        }
        public bool IsKeyReleased(Keys key)
        {
            return (prevKeyboardState.IsKeyDown(key) && currentKeyboardState.IsKeyUp(key));
        }
        public bool IsLeftMouseButtonDown()
        {
            return (currentMouseState.LeftButton == ButtonState.Pressed);
        }
        public bool IsRightMouseButtonDown()
        {
            return (currentMouseState.RightButton == ButtonState.Pressed);
        }
        public Point GetMousePosition()
        {
            return new Point(currentMouseState.X, currentMouseState.Y);
        }
        public bool IsLeftMouseButtonClicked()
        {
            return (prevMouseState.LeftButton == ButtonState.Released &&
                currentMouseState.LeftButton == ButtonState.Pressed);
        }
        public bool IsRightMouseButtonClicked()
        {
            return (prevMouseState.RightButton == ButtonState.Released &&
                   currentMouseState.RightButton == ButtonState.Pressed);
        }
        public bool IsLeftMouseButtonReleased()
        {
            return (prevMouseState.LeftButton == ButtonState.Pressed &&
                currentMouseState.LeftButton == ButtonState.Released);
        }
        public bool IsRightLeftMouseButtonReleased()
        {
            return (prevMouseState.RightButton == ButtonState.Pressed &&
                currentMouseState.RightButton == ButtonState.Released);
        }
    }
}
