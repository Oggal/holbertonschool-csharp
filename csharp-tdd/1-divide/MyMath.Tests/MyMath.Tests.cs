using NUnit.Framework;


namespace MyMath.Tests
{
    public class Tests
    {
        int[,] testmatrix;
        [SetUp]
        public void Setup()
        {
            testmatrix = new int[2,2];
                testmatrix[0,0] = 2;
                testmatrix[0,1] = 4;
                testmatrix[1,0] = 6;
                testmatrix[1,1] = 8;
        }

        [TestCase(1)]
        [TestCase(2)]
        public void NormalFunction(int value)
        {
            int[,] res = MyMath.Matrix.Divide(testmatrix, value);
            Assert.AreEqual(2/value ,res[0,0]);
        }

        [Test]
        public void NullReturn(int value)
        {
            int [,] testA = new int [0,0];
            Assert.IsNull(MyMath.Matrix.Divide(testA,2));
            Assert.IsNull(MyMath.Matrix.Divide(testmatrix, 0));
            Assert.IsNull(MyMath.Matrix.Divide(null, 2));
        }

        
    }
}