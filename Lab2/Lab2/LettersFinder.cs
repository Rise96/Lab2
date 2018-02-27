using System;

namespace Lab2
{
    class LettersFinder
    {
        public int Find3ALetterWordsCount(String inputString)
        {
            string[] words = inputString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (Is3ALetters(words[i]))
                {
                    result++;
                }
            }

            return result;
        }

        private bool Is3ALetters(string word)
        {
            int numberOfLetInWord = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'А')
                {
                    numberOfLetInWord++;
                }
            }
            return numberOfLetInWord == 3;
        }
    }
}
