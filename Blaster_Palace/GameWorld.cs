using Blaster_Palace.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaster_Palace
{
    class GameWorld
    {
      
        public static Graphics Graphics { get; private set; }

        private BufferedGraphics backBuffer;
        private Color backgroundColor;
        public static Size WorldSize { get; private set; }

        private GameObject gameObject;

        public GameWorld(Rectangle displayRectangle, Graphics graphics )
        {
            WorldSize = displayRectangle.Size;

            this.backBuffer = BufferedGraphicsManager.Current.Allocate(graphics, displayRectangle);
            // this.dc = graphics;

            Graphics = backBuffer.Graphics;


            backgroundColor = ColorTranslator.FromHtml("#000c41");
            

            Initialize();

        }

        private void Initialize()
        {

            gameObject = new GameObject();
            Player p = new Player();
            SpriteRenderer sr = new SpriteRenderer();
            gameObject.AddComponent(p);
            gameObject.AddComponent(sr);

            Awake();
            Start();
        
        }

        private void Awake()
        {
            gameObject.Awake();
        }

        private void Start()
        {
        }

        public void Update() 
        {
            MyTime.CalcDeltaTime();
            Graphics.Clear(backgroundColor);
            gameObject.Update();
            backBuffer.Render();
        }
     }
}
