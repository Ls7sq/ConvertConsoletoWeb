using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace ConvertConsoletoWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreatHostBuilder(string[] args) =>
            
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            { 
                webBuilder.UseStartup<Startup>();
            });
            
    }
}
