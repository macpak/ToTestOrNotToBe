using System;

namespace ToTestOrNotToBe.Tasks.Task0
{
    public class FixedChargeCalculator : IChargeCalculator
    {
        private readonly decimal _fixedChargeAmount;

        public FixedChargeCalculator(decimal fixedChargeAmount)
        {
            _fixedChargeAmount = fixedChargeAmount;
        }

        public decimal Calculate(int numberOfTransaction)
        {
            if(numberOfTransaction < 0)
                throw new ArgumentException("Należy podać wartość >= 0","numberOfTransaction");

            return numberOfTransaction * _fixedChargeAmount;
        }
    }
}