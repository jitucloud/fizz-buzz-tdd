using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using FizzBuzzMVC.TDD;
using FizzBuzzMVC.TDD.Controllers;

namespace FizzBuzzMVC.TDD.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Given1Return1()
        {
            FizzBuzzController fbc = new FizzBuzzController();
            ViewResult result = fbc.Index(1) as ViewResult;
            String expected = "1 ";
            String actual = result.ViewBag.Output;
            Assert.AreEqual(expected,actual);
        }


		[Test]
		public void Given3Return12Fizz()
		{
			FizzBuzzController fbc = new FizzBuzzController();
			ViewResult result = fbc.Index(3) as ViewResult;
			String expected = "1 2 Fizz ";
			String actual = result.ViewBag.Output;
			Assert.AreEqual(expected, actual);
		}


        
        [Test]
        public void Given5Return12Fizz4Buzz()
        {
            FizzBuzzController fbc = new FizzBuzzController();
            ViewResult result = fbc.Index(5) as ViewResult;
            String expected = "1 2 Fizz 4 Buzz ";
            String actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);
        }


		[Test]
		public void Given15ReturnFizzBuzz()
		{
			FizzBuzzController fbc = new FizzBuzzController();
			ViewResult result = fbc.Index(15) as ViewResult;
			String expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ";
			String actual = result.ViewBag.Output;
			Assert.AreEqual(expected, actual);
		}


        [Test]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = (ViewResult)controller.Index();

            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            var expectedVersion = mvcName.Version.Major + "." + mvcName.Version.Minor;
            var expectedRuntime = isMono ? "Mono" : ".NET";

            // Assert
            Assert.AreEqual(expectedVersion, result.ViewData["Version"]);
            Assert.AreEqual(expectedRuntime, result.ViewData["Runtime"]);
        }
    }
}
