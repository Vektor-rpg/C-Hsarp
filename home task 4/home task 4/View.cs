using System;


namespace home_task_4
{
    public class View
    {
        public static void Print(object value, bool isNewLine = true)
        {
            if (isNewLine)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.Write(value);
            }

        }

        public static int GetInt()
        {
            int result = 0;
            do
            {
                Print("Введите число");
            } while (!Int32.TryParse(GetString(), out result));
            return result;
        }

        public static double GetDouble()
        {
            double result = 0.0d;
            do
            {
                Print("Введите число");
            } while (!Double.TryParse(GetString().Replace(".", ","), out result));
            return result;
        }

        public static string GetString()
        {
            return Console.ReadLine();
        }

        public static void Pause()
        {
            Console.ReadKey();
        }

        public static void PrintArray(int[] arr, char s = '-')
        {
            for (int index = 0; index < arr.Length; index++)
            {
                var i = arr[index];
                Print($"{s}{i}");
            }
        }

        public static void PrintMatrix(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Print($" {array[i, j]}", false);
                }

                Print(" ");
            }
        }
    }
}