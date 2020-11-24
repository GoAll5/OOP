using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Air
{
    public class FlyCarpet : AirTransport
    {
        public FlyCarpet(string name, int speed)
            : base(name, speed)
        {
        }
        public override double DistanceReducer(double distance)
        {
            if (distance < 1000)
                return distance;
            else if(distance < 5000)
                return (distance * (1 - 0.03));
            else if (distance < 10000)
                return (distance * (1 - 0.1));
            else
                return (distance * (1 - 0.05));
        }
    }
}
