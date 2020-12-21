using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{

    
    public class BankSystem
    {
        public static bool already;
        private static uint CountIdAccount;

        private static uint CountIdOperation;

        private static Dictionary<uint, History> Operations;

        private static Dictionary<uint, Client> Clients;
        public static List<Client> Clientss;

        private static BankSystem bankSystem;

        private static List<Bank> Banks;

        private static Dictionary<uint, Account> Accounts;

        private static List<uint> IdDopMoney;
        private static List<double> DopMoney;

        private static Date DateLine;
        private BankSystem(Date date) {
            CountIdAccount = 0;
            CountIdOperation = 0;
            DateLine = date;
            already = false;
        }


        public static BankSystem getInstance(Date date)
        {   
            if(BankSystem.bankSystem == null)
            {
                BankSystem.bankSystem = new BankSystem(date);
            }
            return BankSystem.bankSystem;
        }

       private static void AddDopMoney(Date date)
        {
            Date date1 = new Date(DateLine.Day, DateLine.Month, DateLine.Year);
            DateLine++;
            if (DateLine.Month == date1.Month)
            {
                for (int i = 0; i < DopMoney.Count || i < IdDopMoney.Count; i++)
                {
                    DopMoney[i] += Accounts[IdDopMoney[i]].dailyupdate(DateLine);
                    DopMoney[i] = 0;
                }
            }
            else
            {
                for (int i = 0; i < DopMoney.Count && i < IdDopMoney.Count; i++)
                {
                    DopMoney[i] += Accounts[IdDopMoney[i]].dailyupdate(DateLine);
                    Accounts[IdDopMoney[i]].monthupdate(DopMoney[i]);
                    DopMoney[i] = 0;
                }
            }
            if (DateLine < date)
                AddDopMoney(date);
        }
       private static bool OtherDate(Date date)
        {
            return DateLine < date;
        }
        private static void CheckDate(Date date)
        {
            if (!OtherDate(date))
                return;
            AddDopMoney(date);
        }

        public void TakeDate(Date date)
        {
            CheckDate(date);
        }
        public void AddBank(string name, double debitPercent, double creditPercent, double firstDepositPercent
, double secondtDepositPercent, double thirdDepositPercent, double limitMoney, Date dateForDebit)
        {

            if (Banks == null)
            {
                Banks = new List<Bank>();
            }

            Banks.Add(new Bank(name, debitPercent, creditPercent, firstDepositPercent
                , secondtDepositPercent, thirdDepositPercent, limitMoney, dateForDebit));

        }
        public void ChangeDateForDebit(string bank, Date dateForDebit)
        {   
            for(int i = 0; i < Banks.Count; i++)
            {
                if(Banks[i].Name == bank)
                {
                    Banks[i].ChangeDateForDebit(dateForDebit);
                }
            }
        }


        public void AddAccount(string bank, Client newClient, string accountType, double money)
        {   
            try
            {   
                CountIdAccount++;
                for (int i = 0; i < Banks.Count; i++)
                {
                    Bank bank1 = Banks[i];
                    if (bank1.Name == bank)
                    {   
                        if(Accounts == null)
                        {
                            Accounts = new Dictionary<uint, Account>();
                        }
                        Accounts.Add(CountIdAccount, bank1.AddAccount(newClient, accountType, money, CountIdAccount));
                        if (Clients == null)
                            Clients = new Dictionary<uint, Client>();
                        Clients.Add(CountIdAccount, newClient);
                        if (Clientss == null)
                            Clientss = new List<Client>();
                        Clientss.Add(newClient);
                        if (DopMoney == null)
                            DopMoney = new List<double>();
                        double dopMoney = 0;
                        DopMoney.Add(dopMoney);
                        if (IdDopMoney == null)
                            IdDopMoney = new List<uint>();
                        IdDopMoney.Add(CountIdAccount);
                        return;
                    }
                }
                CountIdAccount--;
            }
            catch(Exception e)
            {
                CountIdAccount--;
                //Console.WriteLine(e.Message);
            }
        }

        public void Replenishment(uint id, double money)
        {

                if (Accounts.ContainsKey(id))
                {
                        Accounts[id].Replenishment(money);
                        return;
                }
                throw new ReplenishmentException("Не удалось найти айди кому перечислить " + id.ToString());

            //catch
            //{
            //    //Console.WriteLine(e.Message);
            //}

        }

        public void Withdrawal(uint id, double money)
        {
            if (Accounts.ContainsKey(id))
            {
                Accounts[id].Withdrawal(money);
                return;
            }
            throw new WithdrawalException("Не удалось найти айди " + id.ToString());
        }
        public void Transfer(uint idFrom, uint idTo, double money)
        {
            try
            {
                if (idFrom == idTo)
                    return;
                Withdrawal(idFrom, money);
                Replenishment(idTo, money);
                if (Operations == null)
                    Operations = new Dictionary<uint, History>();
                CountIdOperation++;
                Operations.Add(CountIdOperation, new History(idFrom, idTo, money));
                Client clientFrom = Clients[idFrom];
                Client clientTo = Clients[idTo];
                clientFrom.AddOperation(CountIdOperation);
                clientTo.AddOperation(CountIdOperation);
            }
            catch(WithdrawalException)
            {
                CountIdOperation--;
                //Console.WriteLine(e.Message);
            }
            catch (ReplenishmentException)
            {
                CountIdOperation--;
                //Console.WriteLine(e.Message);
                Replenishment(idFrom, money);
            }



        }

        public void ForcedWithdrawal(uint id, double money) // принудительное снятие
        {
            if (Accounts.ContainsKey(id))
            {
                Accounts[id].ForcedWithdrawal(money);
                return;
            }
            throw new ForcedWithdrawalException("Не удалось найти айди мошенника " + id.ToString());

        }

        public void CancelOperation(uint id)
        {
            try
            {
                if (Operations.ContainsKey(id))
                {
                    History cancelOperation = Operations[id];
                    ForcedWithdrawal(cancelOperation.IdTo, cancelOperation.Money);
                    Replenishment(cancelOperation.IdFrom, cancelOperation.Money);
                    cancelOperation.Money = 0;
                }
                else
                    throw new Exception("Не удалось найти айди операции " + id.ToString());
            }
            catch(ForcedWithdrawalException e)
            {
                //Console.WriteLine(e.Message);
            }
            catch (ReplenishmentException e)
            {
                Replenishment(Operations[id].IdTo, Operations[id].Money);
                //Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                //Console.WriteLine(e.Message);
            }

        }


    }
}
