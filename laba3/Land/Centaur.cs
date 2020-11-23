using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Land
{
    public class Centaur : LandTransport
    {
        public Centaur() : base()
        {
            Name = "Кентавр";
            Speed = 15;
            RestInterval = 8;
        }

        public override double RestDuration(int count)
        {
            return 2;
        }
    }
}
