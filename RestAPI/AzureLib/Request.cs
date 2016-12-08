using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureLib
{
    public class Request : IRequest
    {
        IAuth _auth = null;
        Uri _uri = null;
        public Request(IAuth inAuth)     // ctor
        {
            _auth = inAuth;
        }

        // this is specific Execute against Azure API, version 06/01/216 ... and subject to change with future Azure Resource Manager API releases
        public IRestResponse Execute(Method method, Uri url)
        {
            var client = new RestClient(url);

            RestRequest request = new RestRequest(method);

            request.AddHeader("content-type", "application/json");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "bearer " + _auth.GetAcessToken());

            request.AddParameter("api-version", "2016-06-01");

            return client.Execute(request);
        }
        
    }
}
