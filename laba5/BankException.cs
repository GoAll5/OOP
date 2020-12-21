using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
    public class WithdrawalException : Exception
    {
        public WithdrawalException()
        {
        }
        public WithdrawalException(string message) : base(message)
        {
        }
    }

    public class DateException : Exception
    {
        public DateException()
        {
        }
        public DateException(string message) : base(message)
        {
        }
    }

    public class ReplenishmentException : Exception
    {
        public ReplenishmentException()
        {
        }
        public ReplenishmentException(string message) : base(message)
        {
        }
    }

    public class ForcedWithdrawalException : Exception
    {
        public ForcedWithdrawalException()
        {
        }
        public ForcedWithdrawalException(string message) : base(message)
        {
        }
    }
}
