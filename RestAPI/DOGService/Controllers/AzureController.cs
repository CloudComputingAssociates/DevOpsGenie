using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors; //mtm 11-14-2016
using System.Web.Http.Results;
using AzureLib;
using Newtonsoft.Json;
using System.Reflection;
using System.Text;
using Ninject;

namespace DOGService.Controllers
{

    [EnableCors(origins: "http://dogservice.azurewebsites.net", headers:"*", methods:"*")]  //mtm 11-14-2016
    public class AzureController : ApiController
    {
        [HttpGet]
        [Route("api/azure/resourcegroups")]  // attribute routing
        public HttpResponseMessage GetAllResourceGroups()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            IResourceGroup resourceGroup = kernel.Get<IResourceGroup>();
            HttpContent content = new StringContent(JsonConvert.SerializeObject(resourceGroup.GetResourceGroupNames())
                                         , Encoding.UTF8
                                         , "application/json");
            HttpResponseMessage message = new HttpResponseMessage();
            message.Content = content;
            return message;
        }


        //[Route("resourcegroups/{id}")]  
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //[Route("resourcegroups/{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //[Route("resourcegroups/{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
