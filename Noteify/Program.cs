using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Noteify
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetDirectories(Directory.GetCurrentDirectory(),"Configuration*").First())
                .AddJsonFile("Config.json").Build();
            BuildWebHost(args, config).Run();
        }

        public static IWebHost BuildWebHost(string[] args, IConfiguration configuration) =>
            WebHost.CreateDefaultBuilder(args).UseConfiguration(configuration)
                .UseStartup<Startup>()
                .Build();
    }
}
