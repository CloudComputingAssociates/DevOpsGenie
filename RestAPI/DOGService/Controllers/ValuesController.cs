using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors; //mtm 11-14-2016
using System.Web.Http.Results;

namespace DOGService.Controllers
{
    public class ComputeInstance
    {
        public string Name;
    }
    [EnableCors(origins: "http://dogservice.azurewebsites.net", headers:"*", methods:"*")]  //mtm 11-14-2016
    public class ValuesController : ApiController
    {
        // Get
        public IEnumerable<ComputeInstance> Get()
        {
            ComputeInstance[] computeInstances = new ComputeInstance[]
            {
                new ComputeInstance { Name = "Ubuntu2" },
                new ComputeInstance { Name = "WindowsServer2"}
            };

            return computeInstances;
        }

        //public JsonResult<object> Get()
        //{
        //    return Json<object>(new[] {
        //            new { server = "Ubuntu2" },
        //            new { server = "WindowsServer1"} }
        //            );
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
