using System;
using System.Collections.Generic;
namespace Assignment1
{
    public class CountDistinctWordsInString
    {
        public List<string> distinctWordList = new List<string>();
        public int DistinctWords(string wordsTocount)
        {
            int counter=0;
            string[] wordsList= wordsTocount.Split(" ");            
            foreach(string str in wordsList)
            {
                if(!distinctWordList.Contains(str))
                {
                    counter++;
                    distinctWordList.Add(str);
                }
            }
            return counter;
        }
    }
}