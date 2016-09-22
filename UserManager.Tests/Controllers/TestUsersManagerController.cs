using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManager.Controllers;
using System.Web.Mvc;

namespace UserManager.Tests.Controllers
{
    [TestClass]
    public class TestUsersManagerController
    {
        [TestMethod]
        public void TestUsersManagerController1()
        {
            var controller = new UserManagerController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index",result.ViewName);
        }
    }
}
