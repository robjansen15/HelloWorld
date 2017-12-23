using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Core.Data.Models;

namespace HelloWorld.Core.Data.BusinessConfiguration
{
    public class JsonBusinessConfig : IBusinessConfig
    {
        public BusinessEnums LoadConfig(string path)
        {
            string json = System.IO.File.ReadAllText(path);
            BusinessConfigObj businessConfigObj = Newtonsoft.Json.JsonConvert.DeserializeObject<BusinessConfigObj>(json);

            if(businessConfigObj.Entity.ToString().ToLower() == BusinessEnums.HelloWorld.ToString().ToLower())
            {
                return BusinessEnums.HelloWorld;
            }
            else if(businessConfigObj.Entity.ToString().ToLower() == BusinessEnums.HolaWorld.ToString().ToLower())
            {
                return BusinessEnums.HolaWorld;
            }
            else if (businessConfigObj.Entity.ToString().ToLower() == BusinessEnums.BonjourWorld.ToString().ToLower())
            {
                return BusinessEnums.BonjourWorld;
            }
            else
            {
                //BAD STATE
                //Going to throw an exception
                throw new Exception("BAD Configuration!!!");
            }
        }
    }
}
