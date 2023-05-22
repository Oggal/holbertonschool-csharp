using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(2)]
        public void Test1(int value)
        {
            int [,] testmatrix = new int[2,2]();
            testmatrix[0,0] = 2;
            testmatrix[0,1] = 4;
            testmatrix[1,0] = 6;
            testmatrix[1,1] = 8;
            int [,] res = MyMath.Matrix.Divide(testmatrix, value);
            Assert.Pass();
        }
    }
}