using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:5009");

            config.Routes.MapHttpRoute("Default", "api/{controller}/{id}", new {id=RouteParameter.Optional});

            HttpSelfHostServer server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();

            // for waiting
            Console.ReadLine();

        }
    }
}

//  http://localhost:5009/api/orders

// powershell command to open port:
//    netsh http add urlacl url=http://+:5009/ user=m.jebelli
