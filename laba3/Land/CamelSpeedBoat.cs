using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Land
{
    public class CamelSpeedBoat : LandTransport
    {
        public CamelSpeedBoat(string name, int speed, int rest)
            : base(name, speed, rest)
        {

        }

        public override double RestDuration(int count)
        {
            if (count == 1)
                return 5;
            else if (count == 2)
                return 6.5;
            else
                return 8;
        }
    }
}
