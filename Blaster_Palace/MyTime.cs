using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaster_Palace
{
    static class MyTime
    {
        private static DateTime endTime;
        private static DateTime startTime;

        public static float DeltaTime { get; private set; }

        public static void CalcDeltaTime()
        {
            startTime = DateTime.Now;

            if (endTime.Ticks != 0)
            {
                DeltaTime = (startTime.Ticks - endTime.Ticks) / 10000000f;
            
            
            }
            endTime = startTime;
        }
    }
}
