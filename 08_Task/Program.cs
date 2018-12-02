using System;

namespace _08_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете първо число:  ");
            string firstNumber = Console.ReadLine();
            Console.Write("Въведете второ число:  ");
            string secondNumber = Console.ReadLine();
            if (firstNumber.Length > 10000 || secondNumber.Length > 10000)
            {
                Console.WriteLine("Грешка");
            }
            else
            {


                int[] firstArray = new int[firstNumber.Length];
                int[] secondArray = new int[secondNumber.Length];
                int[] resultArray = new int[Math.Max(firstNumber.Length, secondNumber.Length) + 1];

                ToArray(firstNumber, firstArray);
                ToArray(secondNumber, secondArray);

                if (firstArray.Length > secondArray.Length)
                {
                    Array.Copy(secondArray, resultArray, secondArray.Length);
                    SumArrays(resultArray, firstArray);
                }
                else
                {
                    Array.Copy(firstArray, resultArray, firstArray.Length);
                    SumArrays(resultArray, secondArray);
                }


                //int[] resultArray = SumArrays(firstArray, secondArray);

                Array.Reverse(resultArray);

                Console.Write("Сумата на числата е: ");
                int i = 0;
                if (resultArray[i] == 0)
                    i++;
                for (; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i]);
                }
                Console.ReadKey();
            }
        }

        private static void ToArray(string number, int[] array)
        {
            for (int i = 0, j = number.Length - 1; j >= 0; i++, j--)
            {
                array[i] = number[j] - '0';
            }
        }
        private static void SumArrays(int[] result, int[] array1)
        {

            int oneInmind = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] + result[i] + oneInmind <= 9)
                {
                    result[i] = (array1[i] + result[i] + oneInmind) % 10;
                    oneInmind = 0;
                }
                else
                {
                    result[i] = (array1[i] + result[i] + oneInmind) % 10;
                    oneInmind = 1;
                }
            }
            if (oneInmind == 1)
            {
                result[result.Length - 1] = 1;
            }
        }

    }
}

