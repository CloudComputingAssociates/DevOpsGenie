using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureLib
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuth>().To<Auth>();
            Bind<ISubscription>().To<Subscription>();
            Bind<IResourceGroup>().To<ResourceGroup>();
            Bind<IRequest>().To<Request>();
        }
    }
}
