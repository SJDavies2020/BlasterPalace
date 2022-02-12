using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaster_Palace.Components
{
    class Enemy : Component
    {
        private SpriteRenderer spriteRenderer;
        public override void Awake()
        {
            // speed = 50;
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            spriteRenderer.SetSprite("enemy_01");
           
        }


    }
}
