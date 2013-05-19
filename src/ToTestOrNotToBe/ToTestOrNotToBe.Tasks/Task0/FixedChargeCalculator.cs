using System;

namespace ToTestOrNotToBe.Tasks.Task0
{
    public class FixedChargeCalculator : IChargeCalculator
    {
        public decimal Calculate(decimal transactionAmount, int numberOfTransaction)
        {
            if(numberOfTransaction < 0)
                throw new ArgumentException("Należy podać wartość >= 0","numberOfTransaction");

            return numberOfTransaction*transactionAmount;
        }
    }
}