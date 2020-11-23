using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Air
{
    public class Broom : AirTransport
    {
        public Broom(string name, int speed)
            : base(name, speed)
        {
        }
        public override double DistanceReducer(double distance)
        {
            
            return distance * (1 - (0.01 * Math.Truncate(distance / 1000)));
        }
    }
}
