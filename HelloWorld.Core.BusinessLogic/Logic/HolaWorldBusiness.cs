using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Core.BusinessLogic.Logic
{
    public class HolaWorldBusiness : IBusiness
    {
        public string Execute()
        {
            return "Hola World!";
        }
    }
}
