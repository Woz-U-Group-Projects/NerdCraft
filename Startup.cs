using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.EntityFrameworkCore;
using NerdCraft.Models;

namespace NerdCraft
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc();
            services.AddDbContext<ApplicationDbContext>(options => 
            //options.UseMySQL("Data Source=" + Path.GetFullPath("Database/NerdCraft.sql")));
            options.UseMySQL("Server=127.0.0.1; Port=3306; Database=nerdcraft; Uid=root; pwd=Password1!; SslMode=Preferred"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseMySQL("Server=localhost; Port=3306; Database=nerdcraft; Uid=root; pwd=Password1!; SslMode=Preferred", builder =>
        //     {
        //         builder.EnableRetryOnFailure(5, TimesSpan.FromSeconds(10), null);
        //     });
        //     base.OnCongiguring(optionsBuilder);
        // }
    }
}
