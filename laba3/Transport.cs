using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    public abstract class Transport
    {
        public string Name { get; set; }

        public int Speed { get; set; }


        public Transport(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public abstract int Result();
    }
}
