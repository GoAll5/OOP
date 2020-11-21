using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Air
{
    public class FlyCarpet : AirTS
    {
        public FlyCarpet()
        {
            Name = "Ковер-самолет";
            Speed = 10;
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
