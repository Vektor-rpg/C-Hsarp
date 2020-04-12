using System;
using static home_task_4. View;

namespace home_task_4
{
    class Program
    {
        //Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
        //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
        static int GetNumber(int[] array, int length)
        {
            int amountOfPairs = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    amountOfPairs++;
                }
            }
            return amountOfPairs;
        }

        static void Main(string[] args)
        {
            int arrayLength = 20;
            int[] myArray = new int[arrayLength];
            Random random = new Random();
            int result;

            Print("Вас приветствует программа подсчёта пар элементов, в которых хотя бы одно число делится на 3.");
            Print("В следующем массиве [ ");
            for (int i = 0; i < arrayLength; i++)
            {
                myArray[i] = random.Next(-10000, 10000);
                Console.Write(myArray[i] + ", ");
            }
           Print("\b\b ]\n");

            result = GetNumber(myArray, arrayLength);

            Print($"Количество пар: {result}");

            Pause();
        }
    }
}
