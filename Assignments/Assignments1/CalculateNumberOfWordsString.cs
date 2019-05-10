using System;

namespace Assignment1
{
    public class CalculateNumberOfWordsString
    {
        int counter=0;
        public int calculateWords(string stringTocount)
        {
            for(int i=0;i<stringTocount.Length;i++)
            {
                if(stringTocount[i].Equals(' '))
                {
                    counter++;
                }
            }
            counter++;
            if(stringTocount=="")
            {
                return(0);
            }
            else
                return(counter);
        }
    }
}