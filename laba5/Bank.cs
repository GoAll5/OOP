using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{

    class Bank
    {
        public string Name;
        public double DebitPercent;
        public double CreditPercent;
        public double FirstDepositPercent;
        public double SecondtDepositPercent;
        public double ThirdDepositPercent;
        public double LimitMoney;
        public Date DateForDeposit;
        public List<Client> Clients;
        public List<Account> Accounts;
        public Bank(string name, double debitPercent, double creditPercent, double firstDepositPercent, double secondtDepositPercent, double thirdDepositPercent, double limitMoney, Date dateForDebit)
        {
            Name = name;
            DebitPercent = debitPercent;
            CreditPercent = creditPercent;
            FirstDepositPercent = firstDepositPercent;
            SecondtDepositPercent = secondtDepositPercent;
            ThirdDepositPercent = thirdDepositPercent;
            LimitMoney = limitMoney;
            DateForDeposit = dateForDebit;
            Clients = new List<Client>();
            Accounts = new List<Account>();
        }
        public void ChangeDateForDeposit(Date date)
        {
            DateForDeposit = date;
        }

        private bool HaveClient(Client client)
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                Client cl = Clients[i];
                if (cl == client)
                {
                    return true;
                }
            }
            return false;
        }

        public Account AddDebitAccount(Client newClient, double money, uint id)
        {
            Account account = new DebitAccount(id, money, DebitPercent, LimitMoney);
            if (!(HaveClient(newClient)))
                Clients.Add(newClient);
            newClient.AddAccount(account);
            Accounts.Add(account);
            return account;

        }
        public Account AddCreditAccount(Client newClient, double money, uint id)
        {
            Account account = new CreditAccount(id, money, DebitPercent, LimitMoney);
            if (!(HaveClient(newClient)))
                Clients.Add(newClient);
            newClient.AddAccount(account);
            Accounts.Add(account);
            return account;

        }
        public Account AddDepositAccount(Client newClient, double money, uint id)
        {

            double percent;
            if (money < 50000)
                percent = FirstDepositPercent;
            else if (50000 <= money && money < 100000)
                percent = SecondtDepositPercent;
            else
                percent = ThirdDepositPercent;
            Account account = new DepositAccount(id, money, DebitPercent, LimitMoney, DateForDeposit);

            if (!(HaveClient(newClient)))
                Clients.Add(newClient);
            newClient.AddAccount(account);
            Accounts.Add(account);
            return account;

        }


    }
}
