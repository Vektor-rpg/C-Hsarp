using System;
using static home_task_4.View;


namespace home_task_4
{
    class Program1
    {
       
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                else return x;
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("Вас приветствует программа демонстрации возможностей класса для работы с массивом");
            Console.Write("Введите желаемый размер массива: ");
            int size = GetInt();
            Console.Write("Введите первый элемент массива: ");
            int firstElement = GetInt();
            Console.Write("Введите шаг для добавления последующих элементов: ");
            int step = GetInt();

            MyArray a = new MyArray(size, firstElement, step);

            Console.WriteLine("\nСоздан массив: [ " + a.ToString() + " ]\n");

            Console.WriteLine("Сумма элементов массива: " + a.Sum);

            a.Inverse = -1;

            Console.WriteLine("Массив с изменёнными знаками: [ " + a.ToString() + " ]\n");

            Console.Write("Введите число, на которое будут умножены элементы массива: ");

            a.Multi = GetInt();

            Console.WriteLine("Массив, умноженный на число: [ " + a.ToString() + " ]\n");

            Console.WriteLine("Максимальный элемент массива: " + a.Max);

            Console.WriteLine("Количество максимальных элементов массива: " + a.MaxCount);
            Console.ReadKey();
        }
    }
}
