using System;
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
            Configure();
        }

        private void Configure()
        {
            throw new NotImplementedException();
        }
    }
}