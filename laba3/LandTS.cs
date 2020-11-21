﻿using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    public abstract class LandTS : Transport
    {
        public int RestInterval { get; set; }
        public LandTS(string name, int speed, int restInterval)
            : base(name, speed) => RestInterval = restInterval;

        public LandTS()
            : base()
        { }

        public abstract int RestDuration(int count);

        public override double Result(double distance)
        {
            double time = distance / Speed;
            int timeForChill = 0;
            for(int i = 1; i < distance/ RestInterval; i++)
            {
                timeForChill += RestDuration(i);
            }
            time += timeForChill;
            return time;
        }
    }
}
