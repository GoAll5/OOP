using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
    class Client
    {
        public string Name;
        public int PassportId = default(int);
        public string Address = null;
        public Client(string name)
        {
            Name = name;
        }
        public Client(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public Client(string name, int passportId)
        {
            Name = name;
            PassportId = passportId;
        }
        public Client(string name, int passportId, string address)
        {
            Name = name;
            PassportId = passportId;
            Address = address;
        }

        public void GiveAddress(string address)
        {
            Address = address;
        }
        public void GivePassportId(int passportId)
        {
            PassportId = passportId;
        }
    }
}
