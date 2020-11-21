using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    public abstract class LandTS : Transport
    {
        public int RestInterval { get; set; }
        public LandTS(string name, int speed)
            : base(name, speed)
        { }
        public abstract int RestDuration(int count);

        public override int Result()
        {
            //
            return 0;
        }
    }
}
