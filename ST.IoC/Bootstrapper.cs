using ST.Repository.Context;
using ST.Repository.Repositories;
using ST.Service.Services;
using ST.CrossCutting.Interfaces.Repositories;
using ST.CrossCutting.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ST.IoC
{
    public static class Bootstrapper
    {
        public static void ConfigureStApp(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureServices(services);
            ConfigureRepositories(services, configuration);
        }
        private static void ConfigureRepositories(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PersonContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IPersonRepository, PersonRepository>();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
        }
    }
}