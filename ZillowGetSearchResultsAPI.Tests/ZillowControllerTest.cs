// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ZillowControllerTest.cs" company="Liang">
//   Created By Liang Yuan
// </copyright>
// <summary>
//   Defines the ZillowControllerTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ZillowGetSearchResultsAPI.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Controllers;

    /// <summary>The zillow controller test.</summary>
    [TestClass]
    public class ZillowControllerTest
    {
        /// <summary>The ZWS ID.</summary>
        private const string ZWSID = "X1-ZWz1fi61fdynm3_9r65p";

        /// <summary>The test zillow.</summary>
        [TestMethod]
        public void TestZillow()
        {
            var controller = new ZillowController();
            var zillow = controller.Get();
            Assert.AreEqual(zillow, ZWSID);
        }
    }
}
