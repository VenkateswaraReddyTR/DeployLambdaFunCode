using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using TRTA.Diagnostics.Domain.Database;
using TRTA.Diagnostics.Repository;

namespace TRTA.Diagnostics.RuleEngine.Service
{
    public class Startup
    {
        public Startup(IHostingEnvironment env, IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(env.ContentRootPath)
                        .AddEnvironmentVariables()
                        .AddConfiguration(configuration);
            Configuration = builder.Build();
        }

        public static IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddOptions();
            services.AddSingleton(provider => Configuration);
            services.AddSingleton<ISessionManager, SessionManager>();
            services.AddSingleton<IRepository, Domain.Database.Repository>();
            services.AddSingleton<IFileRepository, S3Repository>();
            services.AddSingleton<ICategoryService, CategoryService>();
            services.AddScoped<IRuleService, RuleService>();
            services.AddScoped<IRuleLogService, RuleLogService>();
            services.AddSingleton<ICategoryService, CategoryService>();
            services.AddSingleton<IRuleExecutionLogService, RuleExecutionLogService>();
            services.AddSingleton<IEvaluationRequestService, EvaluationRequestService>();
            services.AddSingleton<ISchemaTypeService, SchemaTypeService>();
            // Add S3 to the ASP.NET Core dependency injection framework.
            services.AddAWSService<Amazon.S3.IAmazonS3>();
            // Register the Swagger generator, defining one or more Swagger documents
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BRMS API", Version = "v1" });
            //    c.OperationFilter<FileOperationFilter>();
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // Enable middleware to serve generated Swagger as a JSON endpoint.
                //app.UseSwagger();
                //app.UseSwaggerUI(c =>
                //{
                //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "BRMS Api V1");
                //});
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
