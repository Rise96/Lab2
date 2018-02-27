using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            String inStr = Console.ReadLine();
            LettersFinder findALetter = new LettersFinder();
            int numberOfWords = findALetter.Find3ALetterWordsCount(inStr);
            Console.WriteLine($"Число слов, в которых встретилось три буквы А, равно {numberOfWords}");
            Console.ReadLine();
        }
    }
}
