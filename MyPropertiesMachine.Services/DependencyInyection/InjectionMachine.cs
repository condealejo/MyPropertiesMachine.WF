using Microsoft.Extensions.DependencyInjection;
using MyPropertiesMachine.Services.Contract;
using MyPropertiesMachine.Services.Implementation;

namespace MyPropertiesMachine.Services.DependencyInyection
{
    public static class InjectionMachine
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            services.AddSingleton<IMachineService, MachineService>();
            return services;
        }
    }
}
