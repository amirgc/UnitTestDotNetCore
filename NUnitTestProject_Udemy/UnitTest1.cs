using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Warnings()
        {
            Warn.If(2 + 2 != 5);
            Warn.If(2 + 2, Is.Not.EqualTo(5));
        }
    }
}