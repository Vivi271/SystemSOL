using System.Linq;

namespace LiskovSubstitutionPrinciple
{
    public class SumCalculator : AddCalculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        {

        }

        public override int Calculate()
        {
            return _numbers.Sum();
        }
    }
}