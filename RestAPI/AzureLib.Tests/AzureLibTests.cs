using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
 

namespace AzureLib.Tests
{
    [TestClass]
    public class AzureLibTests
    {
        
        [TestMethod]
        public void GetSubscriptionsTest()
        {
            Subscription sub = new Subscription();
            string subscr = sub.GetSubscription();
            Assert.IsNotNull(subscr);
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
