using Json_exe.CrunchyrollAPIWrapper.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Json_exe.CrunchyrollAPIWrapper;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddCrunchyrollApiClients(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddRefitClient<ICrunchyrollApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://www.crunchyroll.com"))
            .Services;
    }
}