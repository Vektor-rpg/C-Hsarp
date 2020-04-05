using System;
using static Viev;

namespace home_task_3
{
    //Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
    struct Complex
    {
        public double im;
        public double re;

       
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
       
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
       
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        
        public string  ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        public void ComplexNum()
        {
            Print("Рассмотрим результат работы структуры:");

            Print("Первая пара чисел:");
            Complex complex1;
            complex1.re = GetDouble();
            complex1.im = GetDouble();

            Print("Вторая пара чисел:");
            Complex complex2;
            complex2.re = GetDouble();
            complex2.im = GetDouble();

            
            Complex result = complex1.Plus(complex2);
            Print("Результом операции сложения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                + result.ToString());
            result = complex1.Multi(complex2);
            Print("Результом операции умножения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());
            result = complex1.Minus(complex2);
            Print("Результом операции вычитания чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());

            Pause();

            
        }

        
    }
}

    
