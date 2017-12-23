using System;
using HelloWorld.Core.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Core.Middleware.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        /// <summary>
        /// I am testing my middleware (test the interface), because I am aligning that as an interface between the business and interface layers.
        /// The middleware is the fabric that will hold the application. 
        /// One shortcoming is that if too much dependency falls on the middleware we may become fragile
        /// To avoid this I would continuously refactor and continue abstract components out as they make sense.
        /// </summary>

            
        [TestMethod]
        public void HelloWorldTest()
        {
            //THESE FILES CAN BE FOUND AT THE ROOT OF THE PROJECT
            //THESE FILES CAN BE FOUND AT THE ROOT OF THE PROJECT
            string msg = Handler.Handle(@"D:\Development\Interview\HelloWorld\HelloWorld.json");
            Assert.AreEqual(msg, "Hello World!");
        }

        [TestMethod]
        public void HolaWorldTest()
        {
            //THESE FILES CAN BE FOUND AT THE ROOT OF THE PROJECT
            //THESE FILES CAN BE FOUND AT THE ROOT OF THE PROJECT
            string msg = Handler.Handle(@"D:\Development\Interview\HelloWorld\HolaWorld.json");
            Assert.AreEqual(msg, "Hola World!");
        }

        [TestMethod]
        public void BonjourWorldTest()
        {
            //THESE FILES CAN BE FOUND AT THE ROOT OF THE PROJECT
            //THESE FILES CAN BE FOUND AT THE ROOT OF THE PROJECT
            string msg = Handler.Handle(@"D:\Development\Interview\HelloWorld\BonjourWorld.json");
            Assert.AreEqual(msg, "Bonjour World!");
        }

}
    }
