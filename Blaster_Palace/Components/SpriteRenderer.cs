﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaster_Palace.Components
{
    class SpriteRenderer : Component
    {
        private Graphics graphics;
        private Image sprite;
        
        public RectangleF Rectangle
        {
            get
            {
                return new RectangleF(GameObject.Transform.Position.X, GameObject.Transform.Position.Y, sprite.Width, sprite.Height);
            }
        }

        public SpriteRenderer()
        {
            this.graphics = GameWorld.Graphics;
        }

        public void SetSprite(string spriteName)
        {
            this.sprite = Image.FromFile($@"Sprites/{spriteName}.png");
        }
        public override void Update()
        {
            graphics.DrawImage(sprite, Rectangle);
        }

        public override string ToString()
        {
            return "SpriteRenderer";
        }
    }
}
