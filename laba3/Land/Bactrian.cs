using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Land
{
    public class Bactrian : LandTS
    {
        public Bactrian(string name, int speed) 
            : base(name, speed)
        { }

        public override int RestDuration(int count)
        {
            //
            return 0;
        }
    }
}
