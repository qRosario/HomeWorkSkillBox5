using System;

namespace HomeWorkSkillBox5
{
    internal class Program
    {
        static string[] WordSeparator(string text)
        {
            string[] separatedWords = text.Split(' ');

            return separatedWords;
        }

        static void DataOutput(string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i] + "\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string inputText = Console.ReadLine();
            string[] result = WordSeparator(inputText);
            DataOutput(result);

            Console.ReadLine();


        }
    }
}
