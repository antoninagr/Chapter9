using System;

namespace _07_Task
{
    class Program
    {
        private static int Counter(int number)
        {
            int counter = 0;
            while (number != 0)
            {
                number /= 10;
                counter++;
            }
            return counter;
        }

        static int Reverse(int number)
        {
            int counter = Counter(number);
            int tempVal = 0;
            for (int i = counter - 1; i >= 0; i--)
            {
                tempVal += (number % 10) * (int)Math.Pow(10, i);
                number /= 10;
            }
            return tempVal;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Въведете трицифрено число: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Цифрите му в обратен ред: ");
            Console.WriteLine(Reverse(number));
            Console.ReadKey();
        }
    }
}
