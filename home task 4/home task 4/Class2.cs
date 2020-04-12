﻿using System;
using static home_task_4.View;
  // 2. а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения
  //с заданным шагом.Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, 
  //умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.В Main продемонстрировать работу класса.
namespace home_task_4
{
    class MyArray
    {
        int[] a;

        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
     
        public MyArray(int n, int firstElement, int step)
        {
            a = new int[n];
            a[0] = firstElement;
            for (int i = 1; i < n; i++)
                a[i] = a[i - 1] + step;
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

      
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                    sum += a[i];
                return sum;
            }
        }

        public int Inverse
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * -1;
            }
        }

        public int Multi
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * value;
            }
        }

        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == max) count++;
                return count;
            }
        }

 
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }

      
    }
}
