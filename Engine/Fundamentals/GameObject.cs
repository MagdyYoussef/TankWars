using System.Collections.Generic;

namespace Engine
{
    /// <summary>
    /// The base class that each game object should inherit from.
    /// User Should override Initialize, LoadContent, Update, Draw for every GameObject.
    /// User can use AddtoList() to add a GameObject as a child to this one.
    /// </summary>
    public class GameObject
    {
        List<GameObject> Components;

        public virtual void Initialize()
        {
            if (Components != null)
            {
                foreach (GameObject child in Components)
                    child.Initialize();
            }
        }
        public virtual void LoadContent()
        {
            if (Components != null)
            {
                foreach (GameObject child in Components)
                    child.LoadContent();
            }
        }
        public virtual void Draw()
        {
            if (Components != null)
            {
                foreach (GameObject child in Components)
                    child.Draw();
            }
        }
        public virtual void Update()
        {
            if (Components != null)
            {
                foreach (GameObject child in Components)
                    child.Update();
            }
        }

        public void AddtoList(GameObject child)
        {
            if (Components == null)
                Components = new List<GameObject>();
            Components.Add(child);
        }
    }
}
