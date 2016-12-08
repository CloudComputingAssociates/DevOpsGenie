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
    public class Subscription : ISubscription
    {
        IRequest _request;
        public Subscription(IRequest request)       // ninject request object
        {
            _request = request;
        }
        public string GetSubscriptionId()
        {
            IRestResponse response = _request.Execute(Method.GET, new Uri("https://management.azure.com/subscriptions"));

            JObject jo = JObject.Parse(response.Content);                      

            string subscription = (string)jo["value"][0]["subscriptionId"];    // TODO: mtm 12-02-2016  what if there are multiple subscriptions ?

            return subscription;
        }
    }
}
