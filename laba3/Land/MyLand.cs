using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Land
{
    public class MyLand : LandTS
    {
        private int TimeForFirstChill;
        private int TimeForAfterFirstChill;
        public MyLand(string name, int speed, int rest, int timeForFirstChill) 
            : base(name, speed, rest)
        {
            TimeForFirstChill = timeForFirstChill;
            TimeForAfterFirstChill = timeForFirstChill;
        }
        public MyLand(string name, int speed, int rest, int timeForFirstChill, int timeForAfterFirstChill)
            : base(name, speed, rest)
        {
            TimeForFirstChill = timeForFirstChill;
            TimeForAfterFirstChill = timeForAfterFirstChill;
        }

        public override int RestDuration(int count)
        {
            if (count == 1)
                return TimeForFirstChill;
            else
                return TimeForAfterFirstChill;

        }
    }
}
