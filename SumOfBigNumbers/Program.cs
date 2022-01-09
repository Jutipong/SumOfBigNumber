using SumOfBigNumbers.Services;
using System;

namespace SumOfBigNumbers
{
    class Program
    {
        private static readonly SumOfNumberService _SumOfNumberService = new SumOfNumberService();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Press ESC to exit..\n");

                var input1 = _SumOfNumberService.GetInputNumber("A");
                var input2 = _SumOfNumberService.GetInputNumber("B");
                var result = _SumOfNumberService.SumBigInteger(input1, input2);

                Console.WriteLine($"A + B = {result}\n");
                Console.Write("Press Any key to continue... ");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
