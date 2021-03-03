using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AppWithTemplate.AppCode.Providers;
using AppWithTemplate.AppCode.Repositories;
using AppWithTemplate.Models.DataContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


/*
 * Scaffold-DbContext "Server=.\\SQLExpress;Database=P408;user id=sa;password=query;MultipleActiveResultSets=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -t Products -f
 Scaffold-DbContext "" Microsoft.EntityFrameworkCore.SqlServer -o Models -Tables Products -f   
     */
namespace AppWithTemplate
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
            services.AddControllersWithViews(cfg=> {

                cfg.ModelBinderProviders.Insert(0, new BooleanBinderProvider());
            
            });

            services.AddDbContext<OrganiDbContext>(cfg=>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("cString"));
            });

            services.AddScoped<AppInfoRepository>();

            services.AddRouting(cfg =>
            {
                cfg.LowercaseUrls = true;
                //cfg.LowercaseQueryStrings = true;
            });
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.Seed();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();



            app.UseRequestLocalization();


            CultureInfo ci = new CultureInfo("az");
            ci.NumberFormat.CurrencySymbol = "₼";
            ci.NumberFormat.CurrencyPositivePattern = 3;

            ci.NumberFormat.CurrencyNegativePattern = 3;

            // UseCookieAuthentication..
            // UseJwtBearerAuthentication..

            //add userculture provider for authenticated user
            var requestOpt = new RequestLocalizationOptions();
            requestOpt.SupportedCultures = new List<CultureInfo> { ci
            };
            requestOpt.RequestCultureProviders.Clear();
            requestOpt.RequestCultureProviders.Add(new SingleCultureProvider());

            app.UseRequestLocalization(requestOpt);

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapAreaControllerRoute("areaDefault",
                    "admin",
                    pattern: "admin/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }

    public class SingleCultureProvider : IRequestCultureProvider
    {
        public Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            return Task.Run(() => new ProviderCultureResult("az"));
        }
    }
}
