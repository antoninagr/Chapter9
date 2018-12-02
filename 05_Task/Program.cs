using System;

namespace _05_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array size - ");
            int a = Int32.Parse(Console.ReadLine());
            int[] array = new int[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Select index - ");
            int index = Int32.Parse(Console.ReadLine());
            CheckNeigbours(index, array);
            Console.ReadKey();
        }
        private static void CheckNeigbours(int index, int[] array)
            {
                if (index > array.Length - 1 || index < 0)
                {
                    Console.WriteLine("Wrong position");
                    return;
                }
                if (index == 0)
                {
                    Console.WriteLine("This is the first element");
                    return;
                }
                if (index == array.Length - 1)
                {
                    Console.WriteLine("This is the last element");
                    return;
                }
                if (array[index] > array[index - 1] && array[index] > array[index + 1])
                {
                    Console.WriteLine("Bigger than the neighbours");
                    return;
                }
                if (array[index] < array[index - 1] && array[index] < array[index + 1])
                {
                    Console.WriteLine("Smaller than the neighbours");
                    return;
                }
                else
                {
                    Console.WriteLine("Nor bigger, nor smaller than neighbours");
                    return;
                }
            }
           
        }
    }

