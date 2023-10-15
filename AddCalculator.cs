using System;

namespace LiskovSubstitutionPrinciple
{
    public abstract class AddCalculator
    {
        protected readonly int[] _numbers;

        public AddCalculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Calculate();
    }
}