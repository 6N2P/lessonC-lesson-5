using System;

namespace Lesson_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = InSentence();
            ReversWords(sentence);
            Console.ReadKey();
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
        /// <summary>
        /// Метод разделяет предложения на отдельные слова, записывает их в массив
        /// </summary>
        /// <param name="sentence">Предложение</param>
        static string[] SplitMetod(string sentence)
        {
            string[] masivString = sentence.Split(' ');
            return masivString;
        }

        /// <summary>
        /// Метод реверсирует набор слов
        /// </summary>
        /// <param name="inputSting">Входящее предложение</param>
        static void ReversWords(string inputSting)
        {
            string[] inStringMasive = SplitMetod(inputSting);
            //инверсирую массив
            int l = inStringMasive.Length;
            int k = l / 2;
            string temp=string.Empty;

            for (int i=0; i<k;i++)
            {
                temp = inStringMasive[i];
                inStringMasive[i] = inStringMasive[l - i - 1];
                inStringMasive[l - i - 1] = temp;
                
            }

            for (int i = 0; i < inStringMasive.Length; i++)
            {
                Console.Write($"{inStringMasive[i]} ");
            }
            

        }
    }
}
