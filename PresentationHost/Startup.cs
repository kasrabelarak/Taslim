using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresentationHost.Service;
using Taslim.Core.ApplicationService.Config;
using Taslim.Core.ApplicationService.Facade;
using Taslim.Core.Contracts.Facade;
using Taslim.Core.Contracts.Repository;
using Taslim.Infrastructure.Data;
using Taslim.Infrastructure.EF;

namespace PresentationHost
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
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CategoryProfile());
                mc.AddProfile(new NewsProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddSingleton<IViewerCountService, ViewerCountService>();
            services.AddDbContext<DemoContext>(option => option.UseSqlServer(Configuration.GetConnectionString("taslim")));
            services.AddScoped<INewsRepository, NewsReposiotry>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IAdsRepository, AdsRepository>();
            services.AddScoped<INewsFacade, NewsFacade>();
            services.AddScoped<ICategoryFacade, CategoryFacade>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
