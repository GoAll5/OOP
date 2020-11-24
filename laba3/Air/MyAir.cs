using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Air
{
    public class MyAir : AirTransport
    {
        double Reduce;
        public MyAir(string name, int speed, double reduce)
            : base(name, speed)
        {
            Reduce = reduce;
        }

        public override double DistanceReducer(double distance)
        {
            return (distance * (1 - 0.01 * Reduce));
        }
    }
}
