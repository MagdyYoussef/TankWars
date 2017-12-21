using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TankWars.Game;

namespace TankWars.Screens
{
    struct MapPoint
    {
        public Vector2 Position;
        public string Name;
        public int Level;
        public MapPoint (Vector2 P , string N , int L )
        {
            Position = P; Name = N; Level = L;
        }
    }

    class WorldScreen : Screen
    {
        MapPoint[] MapPoints = new MapPoint[10];
        TextWrapper DisplayInfo;

        public string DisplayText
        {
            get { return DisplayInfo.Text; }
            set { DisplayInfo.Text = value; }
        }

        public override void Initialize()
        {
            TextureWrapper BackGround = new TextureWrapper(new WrapperState(0, 1, 0, Vector2.Zero, Color.White, Vector2.Zero), @"Screens/WorldScreen/WorldScreenBackGround");
            DisplayInfo = new TextWrapper(new WrapperState(0, 1, 0, Vector2.Zero, Color.Black, new Vector2(510, 400)), @"Fonts/Normal", "");

            AddtoList(BackGround);
            AddtoList(DisplayInfo);

            MapPoints[0] = new MapPoint(new Vector2(210, 390), "Brazil", 1);
            MapPoints[1] = new MapPoint(new Vector2(100, 400), "Peru", 2);
            MapPoints[2] = new MapPoint(new Vector2(70, 350), "Venzuela", 3);
            MapPoints[3] = new MapPoint(new Vector2(380, 500), "Cameroon", 4);
            MapPoints[4] = new MapPoint(new Vector2(460, 400), "Egypt", 5);
            MapPoints[5] = new MapPoint(new Vector2(550, 300), "Yamen", 6);
            MapPoints[6] = new MapPoint(new Vector2(630, 300), "India", 7);
            MapPoints[7] = new MapPoint(new Vector2(720, 220), "Japan", 8);
            MapPoints[8] = new MapPoint(new Vector2(500, 120), "Russia", 9);
            MapPoints[9] = new MapPoint(new Vector2(440, 60), "North Pole", 10);

            for (int i = 0; i < 10; i++)
                AddtoList(new WorldButtons.SelectLevelButton(MapPoints[i].Level, MapPoints[i].Position, MapPoints[i].Name, (i < GameState.CurrentProfile.Level) ? true : false));

            AddtoList(new WorldButtons.WorkShopButton(new Vector2(130, 100)));
            AddtoList(new WorldButtons.BackButton());


            base.Initialize();
        }

        public override void Update()
        {
            DisplayInfo.Text = "Select A Level";
            base.Update();
        }
    }
}
