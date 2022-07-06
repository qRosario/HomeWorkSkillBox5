using System;

namespace Dz2
{
    internal class Program
    {

        static string[] WordSeparator(string text)
        {
            string[] separatedWords = text.Split(' ');

            return separatedWords;
        }

        static string ReversWord(string[] text)
        {
            Array.Reverse(text);
            string reverseWord = string.Join(" ", text);
            return reverseWord;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string result = Console.ReadLine();
            result = ReversWord(WordSeparator(result));
            Console.WriteLine(result);

        }
    }
}
