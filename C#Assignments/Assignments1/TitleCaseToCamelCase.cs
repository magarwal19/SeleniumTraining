using System;
namespace Assignment1
{
    public class TitleCaseAndCamelCase
    {
        public string CamelCaseConversion(string stringToConvert)
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
        public string TitleCaseConversion(string stringToConvert)
        {
            string[] arrayString = stringToConvert.Split(" ");
            string tempString1="",finalString1="";
            for(int i=0;i<arrayString.Length;i++)
            {
                for(int j=0;j<arrayString[i].Length;j++)
                {
                    if(j==0)
                    {
                        if(arrayString[i].ToUpper().Equals("A")|| arrayString[i].ToUpper().Equals("AN")|| arrayString[i].ToUpper().Equals("THE"))
                        {
                            tempString1=arrayString[i][j].ToString().ToLower();    
                        }
                        else
                        {
                            tempString1=arrayString[i][j].ToString().ToUpper();    
                        }
                    }
                    else
                    {
                        tempString1+=arrayString[i][j].ToString().ToLower();
                    }
                }
                if(i==0)
                {
                    finalString1=tempString1;
                }
                else
                {
                    finalString1+=" ";
                    finalString1+=tempString1;
                }
            }
            return finalString1;
        }
    }
}