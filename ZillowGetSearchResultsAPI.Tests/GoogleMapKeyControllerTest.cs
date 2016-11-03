// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GoogleMapKeyControllerTest.cs" company="Liang">
//   Created By Liang Yuan
// </copyright>
// <summary>
//   Defines the GoogleMapKeyControllerTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ZillowGetSearchResultsAPI.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Controllers;

    /// <summary>The google map key controller test.</summary>
    [TestClass]
    public class GoogleMapKeyControllerTest
    {
        /// <summary>The google map key.</summary>
        private const string GoogleMapKey = "AIzaSyD3E1D9b-Z7ekrT3tbhl_dy8DCXuIuDDRc";

        /// <summary>The test google.</summary>
        [TestMethod]
        public void TestGoogle()
        {
            var controller = new GoogleMapKeyController();
            var zillow = controller.Get();
            Assert.AreEqual(zillow, GoogleMapKey);
        }
    }
}
