using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using Library.Controllers;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            var controller = new HomeController();
            var result = controller.Privacy() as ViewResult;
            Assert.AreEqual(null, result.ViewName);
        }
    }
}
