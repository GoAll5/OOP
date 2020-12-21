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
        public Date DateForDebit;
        public List<Client> Clients;
        public List<Account> Accounts;
        public Bank(string name, double debitPercent, double creditPercent, double firstDepositPercent
, double secondtDepositPercent,  double thirdDepositPercent, double limitMoney, Date dateForDebit)
        {
            Name = name;
            DebitPercent = debitPercent;
            CreditPercent = creditPercent;
            FirstDepositPercent = firstDepositPercent;
            SecondtDepositPercent = secondtDepositPercent;
            ThirdDepositPercent = thirdDepositPercent;
            LimitMoney = limitMoney;
            DateForDebit = dateForDebit;
            Clients = new List<Client>();
            Accounts = new List<Account>();
        }
        public void ChangeDateForDebit(Date date)
        {
            DateForDebit = date;
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

        public Account AddAccount(Client newClient, Account account, double money, uint id)
        {


            switch (account.Type())
            {
                case "DebitAccount":
                    account.GiveInfo(id, money, DebitPercent, LimitMoney);
                    break;
                case "CreditAccount":
                    account.GiveInfo(id, money, CreditPercent, LimitMoney);
                    break;
                case "DepositAccount":
                    double percent;
                    if (money < 50000)
                        percent = FirstDepositPercent;
                    else if (50000 <= money && money < 100000)
                        percent = SecondtDepositPercent;
                    else
                        percent = ThirdDepositPercent;
                    account.GiveInfo(id, money, percent, LimitMoney);
                    account.GiveDateForDebit(DateForDebit);
                    break;
                default:
                    throw new Exception("Не существует такого счета");
            }
            if(!(HaveClient(newClient)))
                Clients.Add(newClient);
            newClient.AddAccount(account);
            Accounts.Add(account);
            return account;
           
        }


    }
}
