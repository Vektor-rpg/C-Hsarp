using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// * Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения,  которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
namespace Home_task_5
{
    class Program
    {
        static void Mess(string[] args)
        {
            Console.WriteLine("Вас приветствует программа демонстрации возможностей статического класса Message.");

            Console.WriteLine("\nИмеется следующий текст: \n" + Message.text);

            Console.WriteLine("\nВыведем слова текста, которые содержат не более 5 букв:");
            Message.GetWordsByLength(5);

            Console.WriteLine();
            Console.Write("\nУдалим из текста слова, заканчивающиеся на 'я': ");
            Message.DeleteWordByEndChar('я');

            Console.WriteLine();
            Console.WriteLine("\nСамое длинное слово в тексте: " + Message.FindMaxLengthWord());


            Console.WriteLine("\nСформированная строка StringBuilder из самых длинных слов сообщения: \n" + Message.GetLongWordsString());

            Console.ReadKey();
        }
    }
}
