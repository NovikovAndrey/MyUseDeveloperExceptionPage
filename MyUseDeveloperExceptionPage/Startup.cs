using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MyUseDeveloperExceptionPage
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStatusCodePages("text/plain", "Error. Page not found, code = {0}");
            app.Map("/hello", ap => ap.Run(async (context)=>
            {
                await context.Response.WriteAsync($"Page not found");
            }));
            //env.EnvironmentName = "Production";
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/error");
            //}
            //app.Map("/error", ap => ap.Run(async context =>
            //  {
            //      await context.Response.WriteAsync("DivideByZeroException occured");
            //  }));

            ////app.UseRouting();

            //app.Run(async (context) =>
            //{
            //    int x = 0;
            //    int y = 8;
            //    await context.Response.WriteAsync($"{y/x}");
            //});
        }
    }
}
