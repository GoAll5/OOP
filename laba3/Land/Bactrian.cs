﻿using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Land
{
    public class Bactrian : LandTS
    {
        //public Bactrian(string name, int speed, int rest) 
        //    : base(name, speed, rest)
        //{ }

        public Bactrian() : base()
        {
            Name = "Двугорбый верблюд";
            Speed = 10;
            RestInterval = 30;
        }

        public override int RestDuration(int count)
        {
            if (count == 1)
                return 5;
            else
                return 8;
        }
    }
}
