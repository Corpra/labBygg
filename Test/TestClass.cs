using NUnit.Framework;

namespace Test
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void does_one_plus_one_equal_two()
        {
            Assert.AreEqual(1 + 1, 2);
        }
    }
}
