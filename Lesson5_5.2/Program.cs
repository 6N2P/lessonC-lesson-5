using System;
using System.Text;

namespace Lesson5_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string[] wordText = text.Split(" ");

            MinNumbersString(wordText);

            MaxNumberString(wordText);
            Console.ReadKey();
        }

        /// <summary>
        /// Метод возвращает слово с минимальным кролличеством букв
        /// </summary>
        /// <param name="s">Массив</param>
        static void MinNumbersString(string[] s)
        {
            int min = 100;
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                int leng = s[i].Length;

                if (leng < min)
                {
                    min = leng;
                    result = s[i];
                }
            }
            Console.WriteLine($"Слово с минимальным количеством букв: {result}");
        }
        /// <summary>
        /// Метод возвращает строку с максимальным колличеством букв
        /// </summary>
        /// <param name="s">Массив</param>
        static void MaxNumberString(string[] s)
        {
            int max = 0;
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                int leng = s[i].Length;
                if (leng > max)
                {
                    max = leng;
                    result = s[i];
                }
            }
            Console.WriteLine($"Слово с максимальным количеством букв: {result}");
        }
    }
}
