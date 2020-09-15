using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CharpBook
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context => { return context.Response.WriteAsync("This is webserver content."); });
        }
    }
}