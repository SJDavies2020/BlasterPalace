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

        public Component GetComponent(string component)
        {

            return components[component];
        
        }

        public void Awake()
        {
            foreach (Component component in components.Values)
            {
                component.Awake();
            }
        }

        public void Start()
        {

            foreach (Component component in components.Values)
            {
                if (component.IsEnabled)
                {
                component.Start();
                }
            }
        }


        public void Update()
        {
               foreach (Component component in components.Values)
            {
                if (component.IsEnabled)
                {
                 component.Update();
                }
           }
        }
    }
}
