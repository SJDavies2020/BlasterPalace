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

        //private GameObject playerObject;

        private List<GameObject> gameObjects = new List<GameObject>();




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

            GameObject player = new GameObject();
            player.AddComponent(new SpriteRenderer());
            player.AddComponent(new Player());
            gameObjects.Add(player);

            GameObject enemy = new GameObject();
            enemy.AddComponent(new SpriteRenderer());
            enemy.AddComponent(new Enemy());
            gameObjects.Add(enemy);
                       
            Awake();
            Start();
        
        }

        private void Awake()
        {
            //gameObject.Awake();
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Awake();            
            }
        }

        private void Start()
        {

            //gameObject.Awake();
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Start();
            }
        }

        public void Update() 
        {
            MyTime.CalcDeltaTime();
            Graphics.Clear(backgroundColor);

            //gameObject.Awake();
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update();
            }
            backBuffer.Render();
        }
     }
}
