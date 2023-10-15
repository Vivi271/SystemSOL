// Viviana Marcela Garcia Valderrama - 506222720
// Brenda Lorena Vargas Parra - 614222713

using System;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            AddCalculator addition = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {addition.Calculate()}");

            EvenNumbersAddCalculator evenAddition = new EvenNumbersAddCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenAddition.Calculate()}");

            OddNumbersAddCalculator oddAddition = new OddNumbersAddCalculator(numbers);
            Console.WriteLine($"The sum of all the odd numbers: {oddAddition.Calculate()}");
        }
    }
}