using NUnit.Framework;

namespace UnitTestProject2
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod3()
        {
            Assert.That(4, Is.EqualTo(6));
        }

        [Test]
        public void TestMethod4()
        {
            Assert.That(6, Is.EqualTo(6));
        }
    }
}
