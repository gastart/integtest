using NUnit.Framework;

namespace UnitTestProject3
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod3()
        {
            Assert.That(4, Is.EqualTo(6));
        }

        [Category("SpecialSetupRequired")]
        [Test]
        public void TestMethod4()
        {
            Assert.That(5, Is.EqualTo(6));
        }

        [Category("SpecialSetupRequired")]
        [Test]
        public void TestMethod5()
        {
            Assert.That(6, Is.EqualTo(6));
        }
    }
}
