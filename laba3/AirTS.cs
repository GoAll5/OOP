using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    public abstract class AirTS : Transport
    {
        public AirTS(string name, int speed)
            : base(name, speed)
        { }

        public abstract int DistanceReducer(int distance);

        public override int Result()
        {   
            //
            return 0;
        }
    }
}
