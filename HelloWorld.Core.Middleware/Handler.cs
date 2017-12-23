using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Core.BusinessLogic;
using HelloWorld.Core.BusinessLogic.Logic;
using HelloWorld.Core.Data.BusinessConfiguration;
using HelloWorld.Core.Data.Models;

namespace HelloWorld.Core.Middleware
{
    public class Handler
    {
        public static string Handle(string configurationLocation)
        {
            IBusinessConfig config = new JsonBusinessConfig();
            BusinessEnums enumConfig = config.LoadConfig(configurationLocation);

            IBusiness businessLogic = null;

            if(enumConfig == BusinessEnums.HelloWorld)
            {
                businessLogic = new HelloWorldBusiness();
            }        
            else if(enumConfig == BusinessEnums.HolaWorld)
            {
                businessLogic = new HolaWorldBusiness();
            }
            else if(enumConfig == BusinessEnums.BonjourWorld)
            {
                businessLogic = new BonjourWorldBusiness();
            }
            else
            {
                //SAME BAD STATE -- We should probaly get some logging around this or a way to handle this gracefully.
                throw new Exception("Bad state!");
            }
           
            return businessLogic.Execute();
        }
    }
}
