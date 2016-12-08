using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json.Linq;
using Ninject;

namespace AzureLib
{
    public class ResourceGroup : IResourceGroup
    {
        string _subscriptionId = string.Empty;
        IRequest _request = null;

        [Inject]
        public ResourceGroup(IRequest request, ISubscription subscription)
        {
            _request = request;
            _subscriptionId = subscription.GetSubscriptionId();
        }

        public List<SimpleNamedString> GetResourceGroupNames()
        {
            Uri url = new Uri("https://management.azure.com/subscriptions/" + _subscriptionId + "/resourcegroups");

            IRestResponse response = _request.Execute(Method.GET, url);

            JObject jobj = JObject.Parse(response.Content); 

            List<SimpleNamedString> resourceGroupNames = (from rg in jobj["value"]         // stuff into list of serializable objects, SimpleNamedString
                                               select new SimpleNamedString("resourcegroup", (string)rg["name"]))
                                                .ToList<SimpleNamedString>();     
            return resourceGroupNames;
        }
    }
}
