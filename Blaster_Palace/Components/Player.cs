using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blaster_Palace.Components
{
    class Player : Component
    {
        private SpriteRenderer spriteRenderer;

        private Vector2 velocity;

        private float speed;

        public override void Awake()
        {
            speed = 50;
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            spriteRenderer.SetSprite("player");
            GameObject.Transform.Position = new Vector2((GameWorld.WorldSize.Width / 2) - (spriteRenderer.Rectangle.Width / 2), (GameWorld.WorldSize.Height) - (spriteRenderer.Rectangle.Height));
        }

        public override void Update()
        {
            GetInput();
            Move();
        }

        private void GetInput()
        {
            velocity = Vector2.Zero;

            if (Keyboard.IsKeyDown(Keys.W))
            {
                velocity += new Vector2(0, -1);
            }
            if (Keyboard.IsKeyDown(Keys.A))
            {
                velocity += new Vector2(-1, 0);
            }
            if (Keyboard.IsKeyDown(Keys.S))
            {
                velocity += new Vector2(0, 1);
            }
            if (Keyboard.IsKeyDown(Keys.D))
            {
                velocity += new Vector2(1, 0);
            }

            velocity = Vector2.Normalize(velocity);
        }
        private void Move()
        {
            GameObject.Transform.Translate(velocity*speed*MyTime.DeltaTime);
        }

        public override string ToString()
        {
            return "Player";
        }



    }
}
