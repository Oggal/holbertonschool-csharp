using System;
using NUnit.Framework;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class Tests
    {
        BaseClass testCase;
        [SetUp]
        public void Setup()
        {
            testCase = new BaseClass();
        }

        [Test]
        public void PropertyTypeTests()
        {
            Assert.IsInstanceOf<string>(testCase.id);
            Assert.IsInstanceOf<DateTime>(testCase.date_created);
            Assert.IsInstanceOf<DateTime>(testCase.date_updated);
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}