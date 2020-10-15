using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace CharpBook
{
    public class BackGroundWebService : IHostedService
    {
        private IWebHost host;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Serving book in kastrel.");
            Console.WriteLine("");
            host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory() + "//book//")
                .UseStartup<Startup>()
                .Build();
            host.Run();

            return Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.Write("CANCEL");
            await host.StopAsync(cancellationToken);
        }
    }
}