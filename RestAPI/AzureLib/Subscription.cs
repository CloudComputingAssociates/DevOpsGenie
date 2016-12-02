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
    public class Subscription
    {
        string _accessToken;
        public Subscription()
        {
            _accessToken = new Auth().GetAcessToken();
        }
        public string GetSubscription()
        {
            var client = new RestClient("https://management.azure.com/subscriptions");

            RestRequest request = new RestRequest(Method.GET);

            request.AddHeader("content-type", "application/json");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "bearer " + _accessToken);

            request.AddParameter("api-version", "2016-06-01");


            IRestResponse response = client.Execute(request);

            JObject jo = JObject.Parse(response.Content);                      // Newtonsoft JObject parse n query, as opposed to building entity classes/objects

            string subscription = (string)jo["value"][0]["subscriptionId"];    // TODO: mtm 12-02-2016  what if there are multiples( ie; array sub-zero 0 )

            return subscription;
        }
    }
}
