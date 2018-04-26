using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        //[Category("NormalRun")]
        [Test]
        public void TestMethod1()
        {
            Assert.That(0, Is.EqualTo(1))
        }

        [Test]
        public void TestMethod2()
        {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
