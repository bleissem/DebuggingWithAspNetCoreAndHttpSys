using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace DebuggingWithAspNetCoreAndHttpSys.Server
{
    public class Program
    {
        [SupportedOSPlatform("windows")]
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        [SupportedOSPlatform("windows")]

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    // enable httpsys to be able to use Windows authentication
                    webBuilder.UseHttpSys();
                });
    }
}
