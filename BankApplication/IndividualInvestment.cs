using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class IndividualInvestment : BankAccount
    {
        public new void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount < 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be at least 1,000");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}
