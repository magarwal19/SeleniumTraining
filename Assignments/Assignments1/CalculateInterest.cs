using System;
namespace Assignment1
{
    public class CalculateInterest
    {
        //string interestType;
      
        private double totalInterest,totalAmount;
        public double calculateSimpleInterest(double sumOfRupees,double rateOfInterest,double tenureInYears)
        {
            totalInterest=(sumOfRupees*rateOfInterest*tenureInYears)/100;
          
            Console.WriteLine("The total amount to be paid for the given values is " + (totalInterest+sumOfRupees)); 
            return totalInterest;
        }   
        public double calculateCompoundInterest(double sumOfRupees,double rateOfInterest,double tenureInYears
        , double numberOfTimes)
        {
            totalAmount=sumOfRupees * 
                            Math.Pow((1 + rateOfInterest/(numberOfTimes*100)),
                                    (tenureInYears*numberOfTimes));
            totalInterest=totalAmount-sumOfRupees;
            Console.WriteLine("The total amount to be paid for the given values is " + (totalInterest+sumOfRupees)); 
            return totalInterest;
        }  
    }
}
