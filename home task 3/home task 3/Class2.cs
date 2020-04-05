using System;
using static Viev;


namespace home_task_3
{
    class Class2
    {
       
        //static int GetInt()
        //{
        //    while (true)
        //        if (!int.TryParse(Console.ReadLine(), out int x))
        //            Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
        //        else return x;
        //}
       
        static int Check()
        {
            int result = 0;
            bool except;
            do
            {
                except = false;
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    except = true;
                    string message = ex.Message;
                    Console.WriteLine("Возникло исключение: " + message);
                    Console.Write("Пожалуйста, повторите ввод: ");
                }

            } while (except);
            return result;
        }

        public void Recount()
        {
            Console.WriteLine("Вас приветствует программа подсчета нечетных положительных чисел");
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            int Numbers = 0;
            while (true)
            {
                int number = Check();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    Numbers++;
                }
            }

            Console.WriteLine( "Количество чисел: " + Numbers);

            Console.ReadKey();
        }
    }
}
