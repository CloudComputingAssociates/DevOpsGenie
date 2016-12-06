using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureLib.Tests
{
    [TestClass]
    public class AuthTests
    {
        Auth _auth;
        [TestInitialize]
        public void init()
        {
            _auth = new Auth(); 
        }
        [TestMethod]
        public void GetAccessTokenTest()
        {
            Assert.AreNotEqual(string.Empty, _auth.GetAcessToken());
        }
    }
}
