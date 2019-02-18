using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Hospital.Models;
using Microsoft.AspNetCore.Identity;
using Hospital.Util;
using Hospital.ViewModels;

namespace Hospital
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
            //services.AddTransient<IPasswordValidator<User>,
            //        CustomPasswordValidator>(serv => new CustomPasswordValidator(6));

            services.AddDbContext < AuthorizationContext>(options =>

                  options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))) ;

           
            services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.Password.RequiredLength = 6; //минимальная длина
                opts.Password.RequireNonAlphanumeric = false;// требуются ли не алфавитно-цифровые символы
                opts.Password.RequireUppercase = false;// требуются ли символы в верхнем регистре
                opts.Password.RequireLowercase = false;// требуются ли символы в нижнем регистре
                opts.Password.RequireDigit = true;// требуются ли цифры
            })
            .AddEntityFrameworkStores<AuthorizationContext>()
    .AddDefaultTokenProviders();



            services.AddMvc();
        }

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
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(

                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

           
        }
    }
}
