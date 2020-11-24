using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    public abstract class Transport
    {
        public string Name { get;}

        public int Speed { get;}


        public Transport(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
 
        public abstract double Result(double distance);
    }
}
