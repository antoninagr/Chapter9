using System;

namespace _06_Task
{
    class Program
    {
        private static int FirstElementBiggerThanNeigbours(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.Write("Размер на масива: ");
            int a = Int32.Parse(Console.ReadLine());
            int[] array = new int[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Позицията на първия по-голям елемент от съседите си е: ");
            Console.WriteLine(FirstElementBiggerThanNeigbours(array));
            Console.ReadKey();
        }
    }
}
