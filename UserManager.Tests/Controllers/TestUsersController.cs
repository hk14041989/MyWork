using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManager.Controllers;
using System.Web.Mvc;
using UserManager.Models;

namespace UserManager.Tests.Controllers
{
    [TestClass]
    public class TestUsersController
    {
        [TestMethod]
        public void UsersControllerTest1()
        {
            var controller = new UsersController();
            var result = controller.Details(1) as ViewResult;
            var user = (User)result.ViewData.Model;
            Assert.AreEqual("Kiên", user.FirstName);
        }
    }
}
