using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

//temp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.Extensions.Hosting;

//

namespace CharpBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CharpBook!");
            Console.WriteLine("");

            // To start we only take one command with out flasg
            if (args[0] == "init")
            {
                //Create directory structure

                InitBook.Init();
            }

            if (args[0] == "build")
            {
                //Create html output
            }

            if (args[0] == "watch")
            {
                //watch src folder and rebuild the book on changes
            }

            if (args[0] == "serve")
            {
                //Start a local server using watch to update files and push to client to update page

                //Need to start a worker here to monitor src directory for changes

                //TODO start backgroundservice from here
                var bs = new BackGroundWebService();
                CancellationTokenSource ts = new CancellationTokenSource();
                var token = ts.Token;
                var task = Task.Run(() => bs.StartAsync(token));

                while (true)
                {
                    Thread.Sleep(1000);
                    bs.StopAsync(token);
                }
                /*
                //Run Kestrel and startup.cs
                Console.WriteLine("Serving book in kastrel.");
                Console.WriteLine("");
                var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseContentRoot(Directory.GetCurrentDirectory() + "//book//")
                    .UseStartup<Startup>()
                    .Build();
                host.Run();*/
            }
        }
    }
}