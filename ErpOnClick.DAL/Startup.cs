using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Configuration;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ErpOnClick.DAL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ERPonClickContext>(o =>
                 o.UseSqlServer("Server=DEV-MM-LAP6;Database=ERPonClick;Trusted_Connection=True;MultipleActiveResultSets=true")
             );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           
        }
    }
}
