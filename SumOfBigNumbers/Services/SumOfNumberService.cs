using System;
using System.Numerics;

namespace SumOfBigNumbers.Services
{
    public class SumOfNumberService
    {
        private readonly string _typeNumber = "0123456789";

        public BigInteger GetInputNumber(string msg)
        {
            var inputStr = string.Empty;
            ConsoleKeyInfo _key;

            Console.Write($"Input {msg}: ");

            do
            {
                _key = Console.ReadKey(true);
                if (_key.Key != ConsoleKey.Backspace)
                {
                    //Press Esc to Exit
                    if (_key.Key == ConsoleKey.Escape) Environment.Exit(0);

                    //Check input of type number
                    if (CheckOfTypeNnumber(_key.KeyChar.ToString()))
                    {
                        inputStr += _key.KeyChar;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(_key.KeyChar);
                        Console.ResetColor();
                    }
                }
                else
                {
                    if (_key.Key == ConsoleKey.Backspace && inputStr.Length > 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        //Back delete words
                        inputStr = inputStr.Substring(0, (inputStr.Length - 1));
                        Console.Write("\b \b");
                        Console.ResetColor();
                    }
                }
            }
            while ((_key.Key != ConsoleKey.Enter) || (inputStr.Length == 0));

            Console.WriteLine();
            return BigInteger.Parse(inputStr);
        }

        private bool CheckOfTypeNnumber(string inputKey)
        {
            return _typeNumber.IndexOf(inputKey) >= 0;
        }

        public BigInteger SumBigInteger(BigInteger inputA, BigInteger inputB)
        {
            return inputA + inputB;
        }

        public int SumX(int a, int b)
        {
            return a + b;
        }

        
    }
}
