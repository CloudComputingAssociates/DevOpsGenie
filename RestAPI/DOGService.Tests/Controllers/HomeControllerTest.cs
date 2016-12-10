using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DOGService;
using DOGService.Controllers;

namespace DOGService.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void _ControllerHomeIndexTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
