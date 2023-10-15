namespace LiskovSubstitutionPrinciple
{
    public class OddNumbersAddCalculator : AddCalculator
    {
        public OddNumbersAddCalculator(int[] numbers) : base(numbers)
        {

        }

        public override int Calculate()
        {
            int result = 0;

            foreach (var number in _numbers)
            {
                if (number % 2 != 0)
                {
                    result += number;
                }
            }
            return result;
        }
    }
}