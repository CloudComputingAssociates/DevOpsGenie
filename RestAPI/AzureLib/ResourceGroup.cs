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
        string _accessToken;
        // https://management.azure.com/subscriptions/9e2cfc4c-85b3-43a7-aa5c-a7ce38faacc3/resourcegroups   //   append /VMS-resource-group 
        [Inject]
        public ResourceGroup(IAuth auth, ISubscription subscription)
        {
            _accessToken = auth.GetAcessToken();
            _subscriptionId = subscription.GetSubscriptionId();
        }

        public List<KeyValuePair<string, string>> GetResourceGroupNames()
        {
            string[] names = { "", "" };
            var client = new RestClient("https://management.azure.com/subscriptions/" + _subscriptionId + "/resourcegroups");

            RestRequest request = new RestRequest(Method.GET);

            request.AddHeader("content-type", "application/json");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "bearer " + _accessToken);

            request.AddParameter("api-version", "2016-06-01");


            IRestResponse response = client.Execute(request);

            JObject jobj = JObject.Parse(response.Content); // get back JSON from Azure

            List<KeyValuePair<string,string>> resourceGroupNames = (from rg in jobj["value"]         // stuff just those Resource Group names into a list of objects that can be json serialized
                                               select new KeyValuePair<string, string>("resourcegroup", (string)rg["name"]))
                                                .ToList<KeyValuePair<string,string>>();     

            return resourceGroupNames;
        }
    }
}
