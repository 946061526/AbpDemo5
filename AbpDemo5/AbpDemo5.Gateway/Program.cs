using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AbpDemo5.Domain.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbpDemo5.Gateway
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    BuildWebHost(args).Run();
        //}

        //public static IWebHost BuildWebHost(string[] args)
        //{
        //    return WebHost.CreateDefaultBuilder(args)
        //                    .UseStartup<Startup>()
        //                    .UseUrls($"http://{IP}:{Port}")
        //                    .ConfigureAppConfiguration((hostingContext, builder) =>
        //                    {
        //                        builder.AddJsonFile("configuration.json", false, true);
        //                    })
        //                    .Build();
        //}

        public static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder(args)
                      .ConfigureWebHostDefaults(builder =>
                      {
                          builder.UseIISIntegration()
                                 .ConfigureKestrel(options =>
                                 {
                                     options.AddServerHeader = false;
                                 })
                                 .UseUrls($"http://*:{AppSettings.ListenPort}")
                                 .UseStartup<Startup>();
                      }).Build().RunAsync();
        }
    }
}
