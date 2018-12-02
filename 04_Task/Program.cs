using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace _04_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 23, 2321, 43, 234, 24, 234, 3442, 21 };
            int selectedNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The number \"{0}\" is found {1} times in the array",
            selectedNumber, CheckForRepeatance(selectedNumber, numbers));
            Console.ReadKey();
        }
        private static int CheckForRepeatance(int selectedNumber, int[] numbers)

        {
            int counter = 0;
            foreach (int number in numbers)
            {
                if (selectedNumber == number)
                {
                    counter++;
                }
            }
            return counter;
        }

    }
    }
    

