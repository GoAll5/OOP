using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Land
{
    public class Centaur : LandTransport
    {
        public Centaur(string name, int speed, int rest)
            : base(name, speed, rest)
        {

        }
      
        public override double RestDuration(int count)
        {
            return 2;
        }
    }
}
