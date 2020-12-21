using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
   
    public abstract class Account
    {
        public double Money;
        public uint Id;
        public double Percent;
        public double LimitMoney;
        public bool Verified;


        public Account()
        {

        }
        public Account(uint id, double money, double percent, double limitMoney)
        {
            Id = id;
            Money = money;
            Percent = percent;
            Verified = false;
            LimitMoney = limitMoney;
        }
        public abstract void GiveDateForDebit(Date date);
        public void GiveInfo(uint id, double money, double percent, double limitMoney)
        {
            Id = id;
            Money = money;
            Percent = percent;
            Verified = false;
            LimitMoney = limitMoney;
        }
        public abstract void Withdrawal(double money);

        public void Replenishment(double money)
        {
            Money += money;
        }

        public void Transfer(Account account, double money)
        {
            this.Withdrawal(money);
            account.Replenishment(money);
        }

        public void ForcedWithdrawal(double money)
        { 
            Money -= money;
        }
        public abstract double dailyupdate(Date date);
        public abstract void monthupdate(double money);

        public abstract string Type();

    }

    public class DebitAccount : Account
    {
        public override void GiveDateForDebit(Date date)
        {
        }
        public DebitAccount() :base()
        {

        }
        public DebitAccount(uint id, double money, double percent, double limitMoney) : base(id, money, percent, limitMoney)
        {
        }
        public override void monthupdate(double money)
        {
            Money += money;
        }

        public override double dailyupdate(Date date)
        {

            return Math.Round(Money * Percent / 365, 2);

        }
        public override void Withdrawal(double money)
        {   
            if (Verified)
            {
                if (Money >= money)
                    Money -= money;
                else
                {
                    throw new WithdrawalException("Не достаточно средств");
                }
            }
            else
            {
                if (Money >= money && LimitMoney >= money)
                {
                    Money -= money;
                    LimitMoney -= money;
                }
                else
                {
                    throw new WithdrawalException("Не достаточно средств или лимит");
                }

            }
                
        }
        public override string Type()
        {
            return "DebitAccount";
        }



    }
    
    public class CreditAccount : Account
    {
        public override void GiveDateForDebit(Date date)
        {

        }
        public CreditAccount() : base()
        {

        }
        public override void monthupdate(double money)
        {
        }
        public CreditAccount(uint id, double money, double percent, double limitMoney) : base(id, money, percent, limitMoney)
        {  
        }
        public override double dailyupdate(Date date)
        {

            return 0;
        }
        public override void Withdrawal(double money)
        {
            if (Verified)
            {
                if (Money >= money)
                    Money -= money;
                else
                {
                    double newMoney = money + Math.Round(money * Percent / 100, 2);
                    Money -= money;
                }
            }
            else
            {
                if (LimitMoney >= money)
                {
                    if (Money >= money)
                    {
                        Money -= money;
                        LimitMoney -= money;
                        
                    }
                    else
                    {
                        double newMoney = money + Math.Round(money * Percent / 100, 2);
                        LimitMoney -= money;
                        Money -= newMoney;
                    }
                }
                else
                {
                        throw new WithdrawalException("Лимит превышен");
                }

            }
        }
        public override string Type()
        {
            return "CreditAccount";
        }
    }

    public class DepositAccount : Account
    {
        public DepositAccount() : base()
        {

        }
        private bool CanUse;
        private Date CanUseDate;
        public override void monthupdate(double money)
        {
            Money += money;
        }
        public override double dailyupdate(Date date)
        {   
            if(CanUseDate >= date)
            {
                CanUse = true;
            }

            return Math.Round(Money * Percent / 365, 2);
        }
        public override void GiveDateForDebit(Date date)
        {
            CanUseDate = date;
        }
        public DepositAccount(uint id, double money, double percent, double limitMoney, Date canUseDate) : base(id, money, percent, limitMoney)
        {
            CanUse = false;
            CanUseDate = canUseDate;
        }
        public override void Withdrawal(double money)
        {
            if (CanUse)
            {
                if (Verified)
                {
                    if (Money >= money)
                    {
                        Money -= money;
                        return;
                    }
                    throw new WithdrawalException("Не достаточно средств");
                }
                else
                {
                    if (Money >= money && LimitMoney >= money)
                    {   
                        Money -= money;
                        LimitMoney -= money;
                        return;
                    }
                    throw new WithdrawalException("Не достаточно средств или лимит");
                }

            }
            else
                throw new WithdrawalException("Не закончился срок депозита");
        }
        public override string Type()
        {
            return "DepostAccount";
        }
    }
}
