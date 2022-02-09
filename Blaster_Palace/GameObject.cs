using Blaster_Palace.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blaster_Palace
{
    class GameObject
    {
        private Transform transform;
        public Transform Transform{ get; private set; }
        private Dictionary<String, Component> components = new Dictionary<string, Component>();
        public GameObject()
        {
            this.Transform = new Transform();
        }
        public void AddComponent(Component component)
        {
            components.Add(component.ToString(), component);
            component.GameObject = this;
        }
        public void Update()
        {
            //if (Keyboard.IsKeyDown(Keys.D))
            //{
            //    position.X += 1;            
            //}
            //if (Keyboard.IsKeyDown(Keys.A))
            //{
            //    position.X -= 1;
            //}
            //if (Keyboard.IsKeyDown(Keys.W))
            //{
            //    position.Y -= 1;
            //}
            //if (Keyboard.IsKeyDown(Keys.S))
            //{
            //    position.Y += 1;
            //}

            foreach (Component component in components.Values)
            {
                component.Update();
            }

        }
    }
}
