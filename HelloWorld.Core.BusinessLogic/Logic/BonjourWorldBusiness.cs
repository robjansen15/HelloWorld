using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Core.BusinessLogic.Logic
{
    public class BonjourWorldBusiness : IBusiness
    {
        public string Execute()
        {
            return "Bonjour World!";
        }
    }
}
