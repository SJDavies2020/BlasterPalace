using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaster_Palace.Components
{
    abstract class Component
    {

        public bool IsEnabled { get; set; } = true;

        public GameObject GameObject { get; set; }

        public virtual void Awake()
        {
        
        }
        public virtual void Start()
        {
        
        }

        public virtual void Update()
        {

        }


    }
}
