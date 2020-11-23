using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    public abstract class Transport
    {
        public string Name { get; protected set; }

        public int Speed { get; protected set; }


        public Transport(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
        public Transport()
        {
        }
        public abstract double Result(double distance);
    }
}
