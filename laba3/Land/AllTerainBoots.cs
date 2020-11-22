using System;
using System.Collections.Generic;
using System.Text;

namespace laba3.Land
{
    public class AllTerainBoots : LandTS
    {
        public AllTerainBoots() : base()
        {
            Name = "Ботинки-вездеходы";
            Speed = 6;
            RestInterval = 60;
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

