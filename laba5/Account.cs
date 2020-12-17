using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
   
    public abstract class BankAccount
    {
        public double Money;
        public uint Id;
        public double Percent;
        public BankAccount(uint id, double money, double percent)
        {
            Id = id;
            Money = money;
            Percent = percent;
        }
        public BankAccount(uint id, double money)
        {
            Id = id;
            Money = money;
        }
        public abstract void Withdrawal(double money); // снятие

        public void Replenishment(double money)
        {
            Money += money;
        }// пополнение

        public void Transfer(BankAccount account, double money) // перевод
        {
            try
            {
                if (account != null)
                {

                    this.Withdrawal(money);
                    Money += money;
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }

        }  

        public void ForcedWithdrawal(int money) // принудительное снятие
        { 
            Money -= money;
        } 

    }

    public class DebitAccount : BankAccount
    {
        
        public DebitAccount(uint id, double money, double percent) : base(id, money, percent)
        {
        }
        public override void Withdrawal(double money)
        {
            if (Money >= money)
                Money -= money;
            else
            {
                throw new Exception("Не достаточно средств");
            }
        }
  


    }
    
    public class CreditAccount : BankAccount
    {

        public CreditAccount(uint id, double money, double percent) : base(id, money, percent)
        {  
        }

        public override void Withdrawal(double money)
        {
            if (Money >= money)
                Money -= money;
            else 
            {
                money += money * Percent / 100;
                Money -= money;
            }

        }
    }

    public class Deposit : BankAccount
    {
        public bool CanUse;
        public Deposit(uint id, double money) : base(id, money)
        {
            CanUse = false;
            if (money < 50000)
                Percent = 3;
            else if (50000 <= money && money < 100000)
                Percent = 3.5;
            else
                Percent = 4;
        }
        public override void Withdrawal(double money)
        {
            if (CanUse)
                Money -= money;
            else 
                throw new Exception("Не закончился срок депозита");
        }
    }
}
