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
   
    public class ComputeInstance
    {
        string _accessToken = string.Empty;

        public ComputeInstance()
        {
            _accessToken = new Auth().GetAcessToken();
        }
        public void GetVirtualMachines()
        {

            


 
            
        }
    }

}