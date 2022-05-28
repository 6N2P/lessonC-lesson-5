using System;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string InString = InSentence();
            SplitMetod(InString);
            Console.ReadKey();
        }

        /// <summary>
        /// Метод разделяет предложения на отдельные слова, записывает их в массив и выводит на консоль.
        /// </summary>
        /// <param name="sentence">Предложение</param>
        static void SplitMetod (string sentence)
        {
            string[] masivString = sentence.Split(' ');

            foreach (var mas in masivString)
            {
                Console.WriteLine($"{mas}");
            }

        }
        /// <summary>
        /// Метод принимает набор слов пользователя
        /// </summary>
        /// <returns>Возвращает строку слов </returns>
        static string InSentence()
        {
            Console.WriteLine("Введите предложение");
            string InString = Console.ReadLine();
            return InString;
        }

    }
}
