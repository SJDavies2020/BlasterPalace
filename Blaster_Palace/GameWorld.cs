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
        private Graphics dc;

        private BufferedGraphics backBuffer;
        private Color backgroundColor;
        public static Size WorldSize { get; private set; }

        private GameObject gameObject;

        public GameWorld(Rectangle displayRectangle, Graphics graphics )
        {
            WorldSize = displayRectangle.Size;

            this.backBuffer = BufferedGraphicsManager.Current.Allocate(graphics, displayRectangle);
            // this.dc = graphics;
            this.dc = backBuffer.Graphics;
            backgroundColor = ColorTranslator.FromHtml("#000c41");
            gameObject = new GameObject();

            SpriteRenderer sr = new SpriteRenderer(dc);
            sr.SetSprite("player");

            gameObject.AddComponent(sr);



        }
        public void Update() 
        {
            dc.Clear(backgroundColor);
            gameObject.Update();
            backBuffer.Render();
        }
     }
}
