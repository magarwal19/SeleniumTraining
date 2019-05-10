using NUnit.Framework;
using Assignment1;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //test Simple Interest Code
        [Test]
        public void testSI()
        {
            CalculateInterest ci = new CalculateInterest();
            Assert.AreEqual(ci.calculateSimpleInterest(100, 5, 5), 25);
        }
        //Test Compound Interest Code
        [Test]
        public void testCI()
        {
            CalculateInterest ci = new CalculateInterest();
            Assert.AreEqual(ci.calculateCompoundInterest(100, 5, 5, 12), 28.335867850351178d);
        }
        //test the nunmber of words in a string
        [Test]
        public void testNumberOfWords()
        {
            CalculateNumberOfWordsString cal = new CalculateNumberOfWordsString();
            Assert.AreEqual(cal.calculateWords("Test number of Words"), 4);
        }
        //test the number of distinct words in string
        [Test]
        public void testNumberOfDistinctWords()
        {
            CountDistinctWordsInString cal = new CountDistinctWordsInString();
            Assert.AreEqual(6, cal.DistinctWords("test the the number number of unique word"));
        }
        //test the TitleCase to CamelCase
        [Test]
        public void testTitleToCamelCase()
        {
            TitleCaseToCamelCase convert = new TitleCaseToCamelCase();
            Assert.AreEqual("TestATitleCase", convert.titleCaseConversion("Test a Title Case"));
        }
        //test the delegate
        [Test]
        public void testDelegate()
        {
            UseDelegate delegateUsage = new UseDelegate();
            UseDelegate.PerformMaths mathsOperations = new UseDelegate.PerformMaths(delegateUsage.intAdd);
             Assert.AreEqual(20,mathsOperations(15, 5));
            mathsOperations = delegateUsage.intMultiply;
             Assert.AreEqual(2000,mathsOperations(50,40));
            mathsOperations = delegateUsage.intSubstract;
             Assert.AreEqual(12, mathsOperations(20,8));
        }
    }
}