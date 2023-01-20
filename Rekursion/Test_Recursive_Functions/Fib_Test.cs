using NUnit.Framework;
using Rekursion;

namespace Test_Recursive_Functions
{
    public class Fib_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_FibRecursiv_ReturnsCorrectNumber()
        {
            Recursion rec = new Recursion();
            int ret = rec.Fibonacci_Recursion(5);
            Assert.AreEqual(ret, 5);
        }
    }
}