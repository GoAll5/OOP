﻿using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{   

    public abstract class Client
    {
        public List<Account> Accounts;
        public string Name;
        public List<uint> Operations;
        
        public Client(string name)
        {
            Accounts = null;
            Name = name;
        }

        public abstract void AddAccount(Account account);

        public abstract Client GiveAddress(string address);
        public abstract Client GivePassportId(uint passportId);
        public abstract string Type();
        public void AddOperation(uint id)
        {
            if (Operations == null)
                Operations = new List<uint>();
            Operations.Add(id);
        }

    }

    public class VerifiedClient : Client
    {
        public uint PassportId;
        public string Address;

        public VerifiedClient(string name) : base(name)
        {  }
        public override string Type()
        {
            return "Verified";
        }
        public override Client GivePassportId(uint passportId)
        {
            PassportId = passportId;
            return this;
        }
        public override Client GiveAddress(string address)
        {
            Address = address;
            return this;
        }
        public override void AddAccount(Account account)
        {
            if (Accounts == null)
                Accounts = new List<Account>();
            account.Verified = true;
            Accounts.Add(account);
        }

    }

    public class NotVerifiedClient : Client
    {
        public NotVerifiedClient(string name) : base(name)
        { }
        public override string Type()
        {
            return "Verified";
        }
        public override Client GivePassportId(uint passportId)
        {
            VerifiedClient client = new VerifiedClient(Name);
            client.PassportId = passportId;
            if (Accounts != null)
            {
                foreach (Account account in Accounts)
                {
                    account.Verified = true;
                    client.AddAccount(account);
                }
            }
            return client;
        }
        public override Client GiveAddress(string address)
        {
            VerifiedClient client = new VerifiedClient(Name);
            client.Address = address;
            if (Accounts != null)
            {
                    foreach (Account account in Accounts)
                    {
                    account.Verified = true;
                    client.AddAccount(account);
                    }
            }
            return client;
        }
        public override void AddAccount(Account account)
        {
            if (Accounts == null)
                Accounts = new List<Account>();
            account.Verified = false;
            Accounts.Add(account);
        }

    }

}
