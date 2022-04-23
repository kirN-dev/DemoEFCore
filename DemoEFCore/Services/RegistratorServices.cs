using DemoEFCore.MVVM.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace DemoEFCore.Services
{
    public static class RegistratorServices
    {
        public static IServiceCollection AddSevices(this IServiceCollection services) => services
            .AddSingleton<MainViewModel>();
    }
}
