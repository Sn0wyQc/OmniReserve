using Microsoft.Extensions.DependencyInjection;

namespace OmniReserve.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication()
    {
        return services;
    }
}