using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Core.Data.BusinessConfiguration
{
    public interface IBusinessConfig
    {
        Models.BusinessEnums LoadConfig(string path);
    }
}
