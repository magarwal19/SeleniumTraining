using System;
namespace Assignment1
{
    public class UseDelegate
    {
        public delegate int PerformMaths(int a,int b);
        public int intAdd(int a , int b)
        {
            return a+b;
        }
        public int intSubstract(int a , int b)
        {
            return a-b;
        }
        public int intMultiply(int a , int b)
        {
            return a*b;
        }
    }
}