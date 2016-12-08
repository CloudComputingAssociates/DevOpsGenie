using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;
using RestSharp.Authenticators;

namespace AzureLib
{
    public class ResponseContent //This is the actual data that is returned
    {
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public int ext_ispires_in { get; set; }
        public string not_before { get; set; }
        public string resource { get; set; }
        public string access_token { get; set; }
    }
    public class Auth : IAuth
    {
        string _tenantId = string.Empty;            // private member vars
        string _clientId = string.Empty;
        string _clientSecret = string.Empty;
        string _azureAuthURL = string.Empty;
        public Auth(string tenantId = "",string clientId = "",string clientSecret = "")     // ctor
        {
            if (tenantId == string.Empty)
            {
                ReadConfigFile();
            }
            else
            {
                _tenantId = tenantId;
                _clientId = clientId;
                _clientSecret = clientSecret;
            }
            _azureAuthURL = "https://login.microsoftonline.com/" + _tenantId + "/oauth2/token";
            
            // alternatively you can use the name of the tenancy/account as below
            //_azureOAuth2URL = "https://login.microsoftonline.com/martyyoueatinghealthy.onmicrosoft.com/oauth2/token";  
        }
        private string GetEndpointURL()
        {
            return _azureAuthURL;
        }
        public string GetAcessToken()
        {
            string token = string.Empty;

            var client = new RestClient(GetEndpointURL());

            RestRequest request = new RestRequest(Method.POST);

            request.AddHeader("content-type", "application/json");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "client_id:" + _clientId + ", client_secret:" + _clientSecret);

            request.RequestFormat = DataFormat.Json;
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", _clientId);
            request.AddParameter("client_secret", _clientSecret);
            request.AddParameter("resource", "https://management.core.windows.net/");

            IRestResponse response = client.Post(request);

            RestSharp.Deserializers.JsonDeserializer deserializer = new RestSharp.Deserializers.JsonDeserializer();
            ResponseContent content = deserializer.Deserialize<ResponseContent>(response);

            if (!content.access_token.Equals(String.Empty))
            {
                token = content.access_token;
            }

            return token;
        }

        private void ReadConfigFile()
        {
             _tenantId = ConfigurationManager.AppSettings["TenantId"].ToString();
            _clientId = ConfigurationManager.AppSettings["ClientId"].ToString();
            _clientSecret = ConfigurationManager.AppSettings["ClientSecret"].ToString();
        }
    }
}
