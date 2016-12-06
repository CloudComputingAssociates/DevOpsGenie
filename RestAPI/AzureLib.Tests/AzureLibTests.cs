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
        IResourceGroup _resourceGroup;
        ISubscription _subscription;

        [TestInitialize]
        public void init()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            _resourceGroup = kernel.Get<IResourceGroup>();
            _subscription = kernel.Get<ISubscription>();
        }
        [TestMethod]
        public void GetResourceGroupNamesTest()
        {
            List<KeyValuePair<string,string>> names = _resourceGroup.GetResourceGroupNames();
            Assert.IsTrue(names.Count > 0);
        }
        [TestMethod]
        public void GetSubscriptionIdTest()
        {
            string subscr = _subscription.GetSubscriptionId();
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
