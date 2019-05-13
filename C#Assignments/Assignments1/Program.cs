using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int option1 = 0, option2 = 0;
            string inputString = "";
            int val1, val2;
            double sumOfRupees, rateOfInterest, tenureInYears, numberOfTimes, totalInterest;
            Console.WriteLine("Hi Welcome to the program for assignment 2");
            Console.WriteLine("Enter 1 to convert a String to Title Case and Camel Case");
            Console.WriteLine("Enter 2 to print the number of words in a string");
            Console.WriteLine("Enter 3 to print the number of unique words in a string");
            Console.WriteLine("Enter 4 to perfrom maths operation using Delegate");
            Console.WriteLine("Enter 5 to calculate interest");
            Int32.TryParse(Console.ReadLine(), out option1);
            switch (option1)
            {
                case 1:
                    Console.WriteLine("Enter string in Title case which needs to be converted to camel case");
                    inputString = Console.ReadLine();
                    TitleCaseAndCamelCase caseConversion = new TitleCaseAndCamelCase();
                    Console.WriteLine("The value after conversion into Came case is " + caseConversion.CamelCaseConversion(inputString));
                    Console.WriteLine("The value after conversion into Title case is " + caseConversion.TitleCaseConversion(inputString));
                    break;
                case 2:
                    CalculateNumberOfWordsString calculateWords = new CalculateNumberOfWordsString();
                    Console.WriteLine("Enter string to count the number of words");
                    inputString = Console.ReadLine();
                    Console.WriteLine("The number of words in the string are " + calculateWords.calculateWords(inputString));
                    break;
                case 3:
                    CountDistinctWordsInString countDistinctWords = new CountDistinctWordsInString();
                    Console.WriteLine("Enter string to count the number of words");
                    inputString = Console.ReadLine();
                    Console.WriteLine("The number of words in the string are " + countDistinctWords.DistinctWords(inputString));
                    Console.WriteLine("The unique string after removing duplicate words is ");
                    foreach (string str in countDistinctWords.distinctWordList)
                    {
                        Console.Write(str + " ");
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter first value to perform Maths Operation ");
                    Int32.TryParse(Console.ReadLine(), out val1);
                    Console.WriteLine("Enter second value to perform Maths Operation ");
                    Int32.TryParse(Console.ReadLine(), out val2);
                    UseDelegate delegateUsage = new UseDelegate();
                    UseDelegate.PerformMaths mathsOperations = new UseDelegate.PerformMaths(delegateUsage.intAdd);
                    Console.WriteLine("Sum of both number is " + mathsOperations(val1, val2));
                    mathsOperations=delegateUsage.intMultiply;
                    Console.WriteLine("Multiply of both number is " + mathsOperations(val1, val2));
                    mathsOperations=delegateUsage.intSubstract;
                    Console.WriteLine("Substraction of both number is " + mathsOperations(val1, val2));
                    break;
                case 5:
                    CalculateInterest ci = new CalculateInterest();
                    Console.WriteLine("Enter the type of interest you want to calculate");
                    Console.WriteLine("Enter 1 for SI");
                    Console.WriteLine("Enter 2 for CI");
                    Int32.TryParse(Console.ReadLine(), out option2);
                    if (option2 == 2)
                    {
                        Console.WriteLine("Enter the Sum of Ruppeess lended");
                        double.TryParse(Console.ReadLine(), out sumOfRupees);
                        Console.WriteLine("Enter the Rate of interest in percentage");
                        double.TryParse(Console.ReadLine(), out rateOfInterest);
                        Console.WriteLine("Enter the tenure in years for which the money is lended");
                        double.TryParse(Console.ReadLine(), out tenureInYears);
                        Console.WriteLine("Enter the number of times interest is compunded");
                        double.TryParse(Console.ReadLine(), out numberOfTimes);
                        totalInterest = ci.calculateCompoundInterest(sumOfRupees, rateOfInterest, tenureInYears, numberOfTimes);
                        Console.WriteLine("The total simple interest for the given values is " + totalInterest);
                    }
                    else if (option2 == 1)
                    {
                        Console.WriteLine("Enter the Sum of Ruppeess lended");
                        double.TryParse(Console.ReadLine(), out sumOfRupees);
                        Console.WriteLine("Enter the Rate of interest in percentage");
                        double.TryParse(Console.ReadLine(), out rateOfInterest);
                        Console.WriteLine("Enter the tenure in years for which the money is lended");
                        double.TryParse(Console.ReadLine(), out tenureInYears);
                        totalInterest = ci.calculateSimpleInterest(sumOfRupees, rateOfInterest, tenureInYears);
                        Console.WriteLine("The total simple interest for the given values is " + totalInterest);
                    }
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
