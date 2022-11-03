using Contracts;
using Repository;

namespace MotorcycleCompany.Extensions
{
    public static class ServiceExtencion
    {
        public static void ConfigureCors(this IServiceCollection services)=>
        services.AddCors(Options =>
        {
            Options.AddPolicy("CorsPolicy", builder =>
                builder.WithOrigins("htts://sena.edu.co")
                .WithMethods("POST", "GET")
                .WithHeaders("accept", "content-type")
                );
        });

        public static void configureIISIntegratio(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();

    }
}
