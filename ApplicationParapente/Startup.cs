using ApplicationParapente.DataAccess;
using ApplicationParapente.DataModel.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ApplicationParapente
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
            AddTransientDependencies(services);

            services.AddMvc();
        }

        private static void AddTransientDependencies(IServiceCollection services)
        {
            services.AddTransient<RepositoryAsync<Pilot, int>, RepositoryAsync<Pilot, int>>();
            services.AddTransient<RepositoryAsync<Fonction, int>, RepositoryAsync<Fonction, int>>();
            services.AddTransient<RepositoryAsync<Certificate, int>, RepositoryAsync<Certificate, int>>();
            services.AddTransient<RepositoryAsync<Flight, int>, RepositoryAsync<Flight, int>>();
            services.AddTransient<RepositoryAsync<Internship, int>, RepositoryAsync<Internship, int>>();
            services.AddTransient<RepositoryAsync<LandingSite, int>, RepositoryAsync<LandingSite, int>>();
            services.AddTransient<RepositoryAsync<LaunchingSite, int>, RepositoryAsync<LaunchingSite, int>>();
            services.AddTransient<RepositoryAsync<LandingSite, int>, RepositoryAsync<LandingSite, int>>();
            services.AddTransient<RepositoryAsync<Pay, int>, RepositoryAsync<Pay, int>>();
            services.AddTransient<RepositoryAsync<Pilot, int>, RepositoryAsync<Pilot, int>>();
            services.AddTransient<RepositoryAsync<Supervise, int>, RepositoryAsync<Supervise, int>>();
            services.AddTransient<RepositoryAsync<Take, int>, RepositoryAsync<Take, int>>();
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
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
