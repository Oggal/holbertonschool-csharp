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

        [Test]
        public void SimpleAddition()
        {
            int res = MyMath.Operations.Add(1,1);
            Assert.AreEqual(2,res);
        }
        [Test]
        public void BadAddition()
        {
            int res = MyMath.Operations.Add(1.5,1.5);
            Assert.AreEqual(1.5 + 1.5, res);

        }
    }
}