using System;

namespace _02_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter z = ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Max = " + GetMaxInteger(GetMaxInteger(x, y), z));
        }
        public static int GetMaxInteger(int a, int b)
        {
            if (a < b)
            {
                return b;
            }
            return a;
        }
    }
    }

