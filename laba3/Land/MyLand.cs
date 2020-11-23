using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Land
{
    public class MyLand : LandTransport
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

        public override double RestDuration(int count)
        {
            if (count == 1)
                return TimeForFirstChill;
            else
                return TimeForAfterFirstChill;

        }
    }
}
