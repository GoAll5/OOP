using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Land
{
    public class AllTerainBoots : LandTransport
    {
        public AllTerainBoots(string name, int speed, int rest)
            : base(name, speed, rest)
        {

        }

        public override double RestDuration(int count)
        {
            if (count == 1)
                return 10;
            else
                return 5;
        }
    }
}

