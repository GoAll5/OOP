using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Land
{
    public class CamelSpeedBoat : LandTS
    {
        public CamelSpeedBoat() : base()
        {
            Name = "Верблюд-быстроход";
            Speed = 40;
            RestInterval = 10;
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
