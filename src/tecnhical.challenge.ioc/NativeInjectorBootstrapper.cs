namespace ioc
{
    using domain.Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    using technical.challenge.services;
    public static class NativeInjectorBootstrapper
    {
        public static ServiceProvider GetProvider(IServiceCollection services)
        {
            RegistrarServices(services);
            return services.BuildServiceProvider();
        }

        public static void RegistrarServices(IServiceCollection services)
        {
            services.AddTransient<IDivisorService, DivisorService>();
        }
    }
}
