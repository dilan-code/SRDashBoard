using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SrDashboard_SR.DataTransferObject.MapConfiguration;
using SrDashboard_SR.Domain.Services;
using SrDashboard_SR.Domain.Services.Interfaces;
using SrDashboard_SR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR
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
            services.AddRazorPages();
            services.AddControllers();
            services.AddOptions();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigin", builder => builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
            });

            services.AddSwaggerGen(c =>
            {
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
      
            });

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapConfiguration());
            });
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

       
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AteamContext>();
            services.AddRazorPages();



            services.AddDbContext<AteamContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("ATeamDBConnection"),
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 10,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null);
                    });
            });

            services.AddScoped<UserService>();
            services.AddScoped<ConsultantService>();
            services.AddScoped<ConsultantAccountService>();
            services.AddScoped<OfficeService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ATeam - API");

                    // fun but not correct
                    // c.InjectJavascript("/js/redirect.js");
                });

                app.UseSwagger();
            }

            app.UseRouting();

            app.UseCors("AllowAllOrigin");

            //app.UseHttpsRedirection();

            app.UseStaticFiles();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });

        }
    }
}
