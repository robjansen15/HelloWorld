using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Core.Middleware;

namespace HelloWorld.Client.UserClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // THIS IS TO MEET THE BUSINESS REQUIREMENTS
            // Write “Hello World” to the console/screen. 

            Console.WriteLine(Handler.Handle(@"D:\Development\Interview\HelloWorld\HelloWorld.json"));
            Console.WriteLine(Handler.Handle(@"D:\Development\Interview\HelloWorld\HolaWorld.json"));
            Console.WriteLine(Handler.Handle(@"D:\Development\Interview\HelloWorld\BonjourWorld.json"));
            Console.ReadKey();
        }
    }
}
