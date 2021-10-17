using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using RepositoryLayer;
using RepositoryLayer.Repositroy.ProductCategory;
using RepositoryLayer.Repositroy.ProductModel;
using RepositoryLayer.Repositroy.ProductPart;
using RepositoryLayer.Repositroy.ProductSeries;
using ServicesLayer.ProductcategoryService;
using ServicesLayer.ProductmodelService;
using ServicesLayer.ProductPart;
using ServicesLayer.ProductseriesService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCostApi
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProductCostApi", Version = "v1" });
            });

            services.AddDbContext<ApplicationDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("DevelopmentConnection")));

            services.AddScoped(typeof(IProductcategoryRepository<>), typeof(ProductcategoryRepository<>));
            services.AddScoped(typeof(IProductseriesRepository<>), typeof(ProductseriesRepository<>));
            services.AddScoped(typeof(IProductmodelRepository<>), typeof(ProductmodelRepository<>));
            services.AddScoped(typeof(IProductpartRepository<>), typeof(ProductpartRepository<>));

            services.AddTransient<IProductcategoryService, ProductcategoryService>();
            services.AddTransient<IProductseriesService, ProductseriesService>();
            services.AddTransient<IProductmodelService, ProductmodelService>();
            services.AddTransient<IProductPartService, ProductPartService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProductCostApi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
