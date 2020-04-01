using System;
using static Viev;

public class Example
{
    public void MinNumber() // Задание 1. найти наименьшее число
    {
        Print("введите первое число");
        int first = GetInt();

        Print("введите второе число");
        int second = GetInt();

        Print("введите третье число");
        int third = GetInt();

        int MinNumber;

        if (first > second)
        {
            if (third > second)
            {
                MinNumber = second;
            }
            else
            {
                MinNumber = third;
            }
        }
        else
        {
            if (third > first)
            {
                MinNumber = first;
            }
            else
            {
                MinNumber = third;
            }
        }
        Print(MinNumber);
        Pause();
    }

    //----------------------------------------------

    public void Сounter() // Задание 2. подсчет количества цифр в числе
        {
            int n = GetInt();
            int count = 0;

            while (n != 0)
            {
                count++;
                n = n / 10;	
            }
            Print(count);
            Pause();
        }

    //--------------------------------------------------

    public void Recount() // Задание 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    {
        int a, rec = 0;
       
        while (true)
        {
            Print("Введите число");
            a = GetInt();
            if (a != 0)
                {
                     if (a % 2 == 0)
                    { }
                     else
                    {
                    rec++;
                    }
                }
            else
            {
                break;
            }
        }
            
       Print("Введено нечетных чисел" + rec);
        Pause();
    }

    //-----------------------------------------------------

    // 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
    //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
    //С помощью цикла do while ограничить ввод пароля тремя попытками.
    
    public void Login()
    {
        string log = "root";
        string pas = "GeekBrains";

        int count = 0;
        do
        {
            Print("\nВведите логин: ");
            string a = Console.ReadLine();

            Print("Введите пароль: ");
            string b = Console.ReadLine();


            if (log == a && pas == b)
            {

                Print("Добро пожаловать");
                Console.ReadLine();
                break;
            }

            Print("Неверно введен логин или пароль");
            Console.ReadLine();
            ++count;
        } while (count < 3);

    }

    //-------------------------------------------------
    //5.а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;

   public void Fitnes()
    {
        Print("Введите свой вес(кг)");
        Double m = GetDouble();

        Print("Введите свой рост(м)");
        Double h = GetDouble();

        Double i = ( m/(h*h));
        if (i > 18 && i < 25)
            Print("Ваш вес в норме");
        if (i < 18)
            Print("У вас недостача веса");
        if (i > 25)
            Print("У вас перебор веса");
    }



}




