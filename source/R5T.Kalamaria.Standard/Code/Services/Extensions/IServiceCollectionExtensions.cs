using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Kalamaria.Default;


namespace R5T.Kalamaria.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddOrganizationsDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationsDirectoryNameConvention, OrganizationsDirectoryNameConvention>();

            return services;
        }
    }
}
