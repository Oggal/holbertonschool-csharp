using System;
using NUnit.Framework;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class Tests
    {
        BaseClass testCase;
        Item testItem;
        User testUser;

        [SetUp]
        public void Setup()
        {
            testCase = new BaseClass();
            testItem = new Item("testItem");
            testUser = new User("testUser");
        }

        [Test]
        public void PropertyTypeTests()
        {
            Assert.IsInstanceOf<string>(testCase.id);
            Assert.IsInstanceOf<DateTime>(testCase.date_created);
            Assert.IsInstanceOf<DateTime>(testCase.date_updated);

            Assert.IsNotNull(testCase.id);
            Assert.IsNotNull(testCase.date_created);
            Assert.IsNotNull(testCase.date_updated);
        }

        [Test]
        public void ItemTest()
        {
            Assert.IsInstanceOf<string>(testItem.name);
            Assert.IsInstanceOf<string>(testItem.description);
            Assert.IsInstanceOf<float>(testItem.price);
            Assert.IsInstanceOf<string[]>(testItem.tags);

            Assert.IsNotNull(testItem.name);
        }

        [TestCase( new object[] {"dogs"}, ExpectedResult =  1)]
        [TestCase( new object[] {"dogs", "cats"}, ExpectedResult =  2)]
        [TestCase( new object[] {"dogs", "cats", "dogs"}, ExpectedResult =  2)]
        [TestCase( new object[] {"dogs", "cats", "dogs", "cats"}, ExpectedResult =  2)]
        [TestCase( new object[] {}, ExpectedResult =  0)]
        public int TagCountTest(params string[] value)
        {
            Item LocalItem;
            try
            {
                LocalItem = new Item("testItem", tags: value);
                return LocalItem.tags.Length;
            }
            catch
            {
                Assert.Fail();
            }
            
            return -1;
        }

        [Test]
        public void UserTest()
        {
            Assert.IsInstanceOf<string>(testUser.name);

            Assert.IsNotNull(testUser.name);
        }
    }
}