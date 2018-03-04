using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string start = Request.Form["startDate"];
            string end = Request.Form["endDate"];
            string period = Request.Form["inlineRadioOptions"];
            string price = Request.Form["price"];
            

            string startDate = startDate.Value;


            var host = new WebHostBuilder()

                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
