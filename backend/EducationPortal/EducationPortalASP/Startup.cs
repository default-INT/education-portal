using System;
using EducationPortalASP.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EducationPortalASP.Data;

namespace EducationPortalASP
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
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<EducationPortalContext>(options => options.UseNpgsql(connection));

            services.AddIdentity<Account, IdentityRole>(
                opts =>
                {
                    opts.Password.RequiredLength = 5;   // ����������� �����
                    opts.Password.RequireNonAlphanumeric = false;   // ��������� �� �� ���������-�������� �������
                    opts.Password.RequireLowercase = false; // ��������� �� ������� � ������ ��������
                    opts.Password.RequireUppercase = false; // ��������� �� ������� � ������� ��������
                    opts.Password.RequireDigit = false;
                }) 
                .AddEntityFrameworkStores<EducationPortalContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseAuthentication();
            app.UseHttpsRedirection();
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
