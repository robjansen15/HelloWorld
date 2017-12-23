using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorld.Web.Api.Controllers
{
    public class BusinessController : ApiController
    {

        //This has not been tested -- This is just here for demonstrate purposes
        //Your end users (clients) could then be connected to the Middletear through a REST or SOAP.
        //I personally love WFC as it is extremely seamless in the .NET environment.

        [HttpPost]
        public string Get()
        {
            //Configuration location could be saved in a singleton or another variable
            string dummy = @"D:\Development\Interview\HelloWorld\BonjourWorld.json";

            return HelloWorld.Core.Middleware.Handler.Handle(dummy);
        }

    }
}
