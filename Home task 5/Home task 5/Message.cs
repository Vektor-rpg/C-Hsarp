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
    
    static class Message
    {
        static public string text;

        static Message()
        {
            text = "Лейтенант шел по желтому строительному песку, нагретому дневным палящим солнцем. " +
                "Он был мокрым от кончиков пальцев до кончиков волос, все его тело было усеяно царапинами " +
                "от острой колючей проволоки и ныло от сводящей с ума боли, но он был жив и направлялся к командному штабу, " +
                "который виднелся на горизонте метрах в пятистах. Повторим несколько слов для частотного анализа: шел, его, его, тело, жив, он, ";
        }

        
        static public void GetWordsByLength(int len)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= len)
                    Console.Write(word + " ");
            }
        }

        static public void DeleteWordByEndChar(char ch)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == ch)
                {
                    Console.Write(word + " ");
                    text.Replace(word, "");
                }
            }
        }

        static public string FindMaxLengthWord()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            return maxWord;
        }

        static public StringBuilder GetLongWordsString()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            StringBuilder result = new StringBuilder();
            int max = Message.FindMaxLengthWord().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            return result;
        }
    }
}
