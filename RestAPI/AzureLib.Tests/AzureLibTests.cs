using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Ninject;
using System.Reflection;

namespace AzureLib.Tests
{
    [TestClass]
    public class AzureLibTests
    {
        StandardKernel _kernel = null;
        [TestInitialize]
        public void init()
        {
            _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
        }
        [TestMethod]
        public void ComputeGetVirtualMachinesTest()
        {
            ICompute compute = _kernel.Get<ICompute>();
            List<SimpleNamedString> names = compute.GetVirtualMachines("VMS-resource-group");
            Assert.AreEqual("Ubuntu2", names[0].value);
        }
        [TestMethod]
        public void ResourceGroupGetResourceGroupNamesTest()
        {
            IResourceGroup resourceGroup = _kernel.Get<IResourceGroup>();
            List<SimpleNamedString> names = resourceGroup.GetResourceGroupNames();
            Assert.IsTrue(names.Count > 0);
        }
        [TestMethod]
        public void SubscriptionGetSubscriptionIdTest()
        {
            ISubscription subscription = _kernel.Get<ISubscription>();
            string subscr = subscription.GetSubscriptionId();
            Assert.IsNotNull(subscr);
        }
    }
}
