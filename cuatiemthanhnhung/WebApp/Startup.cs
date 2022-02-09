using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using Services.Services;

namespace WebApp
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });



            #region Dependency Injection

            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IBlogCategoryService, BlogCategoryService>();
            services.AddTransient<IBlogService, BlogService>();
            services.AddTransient<IBlogDetailService, BlogDetailService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IBillService, BillService>();
            services.AddTransient<IBillDetailService, BillDetailService>();
            services.AddTransient<IInformationService, InformationService>();
            services.AddTransient<IEmailService, EmailService>();

            #endregion
            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromHours(2);
                option.Cookie.HttpOnly = true;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");


                routes.MapRoute(
                 name: "kien-thuc-theo-danh-muc",
                 template: "kien-thuc/{id}/{name}.html",
                 defaults: new
                 {
                     controller = "Blog",
                     action = "Blog",
                     id = UrlParameter.Optional,
                     name = UrlParameter.Optional
                 });

                routes.MapRoute(
                   name: "kien-thuc",
                   template: "kien-thuc",
                   defaults: new
                   {
                       controller = "Blog",
                       action = "Blog",

                   });


            });
        }
    }
}
