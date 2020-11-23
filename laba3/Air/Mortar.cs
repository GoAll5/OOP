using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Air
{
    public class Mortar : AirTransport
    {
        public Mortar(string name, int speed)
            : base(name, speed)
        {
        }

        public override double DistanceReducer(double distance)
        {
            return (distance * (1 - 0.06));
        }
    }
}
