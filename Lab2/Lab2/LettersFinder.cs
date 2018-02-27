using System;

namespace Lab2
{
    class LettersFinder
    {
        public int FindALetter(String inStr)
        {
            int result=0;
            int numOfLetInWord=0;
            for(int i = 0; i < inStr.Length; i++)
            {
                if(inStr[i]=='A')
                {
                    numOfLetInWord++;
                }
                if(inStr[i]==' ')
                {
                    numOfLetInWord=0;
                }
                if (numOfLetInWord == 3)
                {
                    numOfLetInWord = 0;
                    result++;
                }
            }
            return result;
        }
    }
}
