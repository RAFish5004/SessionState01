// ======================================================
// SessionState01.sln, 210513
// Author: Russell Fisher
// https://www.c-sharpcorner.com/article/how-to-use-session-in-asp-net-core/
// ======================================================

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionState01 // -----------------------------------------------------------------------
{
    public class Startup // -----------------------------------------------------------------------
    {
        // constructor
        public Startup(IConfiguration configuration) // -------------------------------------------
        {
            Configuration = configuration;

        } // eo Startup constructor ---------------------------------------------------------------

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services) // -----------------------------
        {
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(5);//You can set Time   
            });
            services.AddMvc();

            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // p 273    
            //services.AddMvc();
            //services.AddMemoryCache();
            //services.AddSession();
        } // eo ConfitureServices method ----------------------------------------------------------

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // ----------------
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseHttpsRedirection();

            app.UseSession();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {               
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        } // eo Configure method ------------------------------------------------------------------

    } // eo Startup.cs class ----------------------------------------------------------------------
} // eo namespace
