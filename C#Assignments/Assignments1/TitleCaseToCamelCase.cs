using System;
namespace Assignment1
{
    public class TitleCaseToCamelCase
    {
        public string titleCaseConversion(string stringToConvert)
        {
            string[] arrayString = stringToConvert.Split(" ");
            string tempString="",finalString="";
            for(int i=0;i<arrayString.Length;i++)
            {
                for(int j=0;j<arrayString[i].Length;j++)
                {
                    if(j==0)
                    {
                        tempString=arrayString[i][j].ToString().ToUpper();
                    }
                    else
                    {
                        tempString+=arrayString[i][j].ToString().ToLower();
                    }
                }
                if(i==0)
                {
                    finalString=tempString;
                }
                else
                {
                    finalString+=tempString;
                }
            }
            return finalString;
        }
    }
}