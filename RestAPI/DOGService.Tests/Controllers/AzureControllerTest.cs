using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DOGService;
using DOGService.Controllers;
using System.Web.Http.Results;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace DOGService.Tests.Controllers
{

    public class ResourceClass 
    {   
        public string resourcegroup;
    }

    [TestClass]
    public class AzureControllerTest
    {
        [TestMethod]
        public void APIGetAllResourceGroups()
        {
            // Arrange
            AzureController controller = new AzureController();

            // Act
            HttpResponseMessage response = controller.GetAllResourceGroups();

            var definition = new { resourcegroup = "" };

            List<ResourceClass> extracted= JsonConvert.DeserializeObject<List<ResourceClass>>(response.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(extracted[0].resourcegroup, "DOGService-resource-group");
        }

        //[TestMethod]
        //public void GetById()
        //{
        //    // Arrange
        //    AzureController controller = new AzureController();

        //    // Act
        //    string result = controller.Get(5);

        //    // Assert
        //    Assert.AreEqual("value", result);
        //}

        //[TestMethod]
        //public void Post()
        //{
        //    // Arrange
        //    AzureController controller = new AzureController();

        //    // Act
        //    controller.Post("value");

        //    // Assert
        //}

        //[TestMethod]
        //public void Put()
        //{
        //    // Arrange
        //    AzureController controller = new AzureController();

        //    // Act
        //    controller.Put(5, "value");

        //    // Assert
        //}

        //[TestMethod]
        //public void Delete()
        //{
        //    // Arrange
        //    AzureController controller = new AzureController();

        //    // Act
        //    controller.Delete(5);

        //    // Assert
        //}
    }
}
