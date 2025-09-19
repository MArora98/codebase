using System;
using NUnit.Framework;

namespace Classes.Tests
{
    [TestFixture]
    public class TestClass
    {
        public string Username { get; set; }
        public int UserId { get; set; }

        [Test]
        public void SampleTest()
        {
            Assert.Pass("Sample test passed.");
        }
    }
}
