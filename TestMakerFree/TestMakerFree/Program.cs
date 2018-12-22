using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TestMakerFree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*In a very few words, a host is the execution context of any ASP.NET Core app.
            In a web - based application, the host must implement the IWebHost interface, which exposes a collection of web-related features and services and also a Start method.
            The Web Host references the server that will handle requests.
            
            The host is responsible for application startup and lifetime management.The server is responsible for accepting HTTP requests.
            Part of the host's responsibility includes ensuring that the application's services and the server are available and properly configured.
            We could think of the host as being a wrapper around the server. 
            The host is configured to use a particular server; the server is unaware of its host.*/

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        /*The WebHost.CreateDefaultBuilder() method is one of the many improvements of ASP.NET Core 2.0 over its 1.x counterpart
         It is equivalent to this code in .Net Core 1.x

        var host = new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory()) // Setting the Content root folder, that is, where to look for the appsettings.json file and other configuration files
            .UseIISIntegration()
            .UseStartup<Startup>()
            .UseApplicationInsights()
            .Build();

            host.Run();
         
         */
    }
}
