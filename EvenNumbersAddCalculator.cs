namespace LiskovSubstitutionPrinciple
{
    public class EvenNumbersAddCalculator : AddCalculator
    {
        public EvenNumbersAddCalculator(int[] numbers) : base(numbers)
        {

        }

        public override int Calculate()
        {
            int result = 0;

            foreach (var number in _numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
            }
            return result;
        }
    }
}