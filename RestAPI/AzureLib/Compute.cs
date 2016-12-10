using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json.Linq;

namespace AzureLib
{
   
    public class Compute : ICompute
    {
        IRequest _request = null;
        ISubscription _subscription = null;

        public Compute(IRequest request, ISubscription subscription)
        {
            _request = request;
            _subscription = subscription;
        }
        public List<SimpleNamedString> GetVirtualMachines(string resourceGroupString)
        {

            Uri url = new Uri("https://management.azure.com/subscriptions/" + _subscription.GetSubscriptionId() + "/ResourceGroups/" 
                                + resourceGroupString + "/providers/Microsoft.Compute/VirtualMachines");

            IRestResponse response = _request.Execute(Method.GET, url);

            JObject jobj = JObject.Parse(response.Content);

            List<SimpleNamedString> virtualMachines = (from rg in jobj["value"]
                                                          select new SimpleNamedString("name", (string)rg["name"]))
                                    .ToList<SimpleNamedString>();
            return virtualMachines;

        }
    }

}