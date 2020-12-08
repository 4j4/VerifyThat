using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VerifyThat;
using static VerifyThat.Verify;

namespace VerifyThat.Tests
{
    [TestClass]
    public class VerifyTests
    {
        [TestMethod]
        public void That_ComparesTwoStrings()
        {
            Assert.IsTrue(Verify.That(RetrieveData("1"), equals, "1"));
        }

        [TestMethod]
        public void That_ComparesStringToInteger()
        {
            Assert.IsTrue(Verify.That(RetrieveData("1"), equals, 1));
        }

        private string RetrieveData(string result)
        {
            return result;
        }

    }
}
