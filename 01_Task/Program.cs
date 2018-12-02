using System;

namespace _01_Task
{
    class Program
    {
        public static void Hello()
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            {
                Hello();
            }
        
        }
    }
}
