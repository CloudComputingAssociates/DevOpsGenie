using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
 

namespace AzureLib.Tests
{
    [TestClass]
    public class ComputeInstanceTests
    {
        
        [TestMethod]
        public void GetSubscriptionsTest()
        {
            Subscription sub = new Subscription();
            string json = sub.GetSubscriptions();
            Assert.IsNotNull(json);
        }
        [TestMethod]
        public void GetVirtualMachinesTest()
        {
            ComputeInstance ci = new ComputeInstance();

            ci.GetVirtualMachines();
            Assert.IsTrue(true);
        }
    }
}
