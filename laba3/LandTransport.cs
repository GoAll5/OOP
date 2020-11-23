using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    public abstract class LandTransport : Transport
    {
        public int RestInterval { get;}
        public LandTransport(string name, int speed, int restInterval)
            : base(name, speed) => RestInterval = restInterval;


        public abstract double RestDuration(int count);

        public override double Result(double distance)
        {
            double time = distance / Speed;
            double timeForChill = 0;
            for(int i = 1; i < distance/ RestInterval; i++)
            {
                timeForChill += RestDuration(i);
            }
            time += timeForChill;
            return time;
        }
    }
}
