using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
    class History
    {
        public uint IdFrom;
        public uint IdTo;
        public double Money;

        public History(uint idFrom, uint idTo, double money)
        {
            IdFrom = idFrom;
            IdTo = idTo;
            Money = money;
        }
    }
}
