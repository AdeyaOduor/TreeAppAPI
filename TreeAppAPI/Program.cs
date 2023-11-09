using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace TreeAppAPIv1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var logger = NLog.Web.NLogBuilder.ConfigureNLog("nLog.config").GetCurrentClassLogger();
            try
            {
                //logger.Debug("Application Starting Up");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception e)
            {
                //logger.Error(e);
                Console.WriteLine(e);
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .CaptureStartupErrors(true)
                .UseSetting("detailedErrors", "true")
                .UseStartup<Startup>();

    }
}
