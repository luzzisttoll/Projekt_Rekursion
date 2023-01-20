using NUnit.Framework;
using Rekursion;

namespace Test_Recursive_Functions
{
    public class Fakultät_Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_FixNumberRecursive_ReturnsCorrectSum()
        {
            Recursion rec = new Recursion();
            int ret = rec.Fakultät_Recursion(4);
            Assert.AreEqual(ret, 24);
        }
    }
}