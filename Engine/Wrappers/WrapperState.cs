using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Engine
{
    public class WrapperState
    {
        int m_DrawOrder;
        float m_Scale;
        float m_Rotation;
        Vector2 m_Origin;
        Color m_DrawColor;
        Vector2 m_Position;

        public int DrawOrder
        {
            get { return m_DrawOrder; }
        }
        public float Scale
        {
            get { return m_Scale; }
        }
        public float Rotation
        {
            get { return m_Rotation; }
        }
        public Vector2 Origin
        {
            get { return m_Origin; }
        }
        public Color DrawColor
        {
            get { return m_DrawColor; }
        }
        public Vector2 Position
        {
            get { return m_Position; }
        }

        public WrapperState(int DrawOrder, float Scale, float Rotation, Vector2 Origin, Color DrawColor, Vector2 Position)
        {
            this.m_DrawOrder = DrawOrder;
            this.m_Scale = Scale;
            this.m_Rotation = Rotation;
            this.m_Origin = Origin;
            this.m_DrawColor = DrawColor;
            this.m_Position = Position;
        }
    }
}
