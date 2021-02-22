using NUnit.Framework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class SysVTests
    {
        [Test]
        public void Test_it()
        {
            var svc = SysV.SysVEnvironment.Load();
            Assert.AreEqual("SysV", svc.Name);
        }
    }
}
