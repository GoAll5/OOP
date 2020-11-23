using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Air
{
    public class Mortar : AirTransport
    {
        public Mortar()
        {
            Name = "Ступа";
            Speed = 8;
        }

        public override double DistanceReducer(double distance)
        {
            return (distance * (1 - 0.06));
        }
    }
}
