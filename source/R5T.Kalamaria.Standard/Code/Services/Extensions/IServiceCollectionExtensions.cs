using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Kalamaria.Default;


namespace R5T.Kalamaria.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IOrganizationsDirectoryNameConvention"/> service.
        /// </summary>
        public static IServiceCollection AddOrganizationsDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddDefaultOrganizationsDirectoryNameConvention();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationsDirectoryNameConvention"/> service.
        /// </summary>
        public static ServiceAction<IOrganizationsDirectoryNameConvention> AddOrganizationsDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationsDirectoryNameConvention>(() => services.AddOrganizationsDirectoryNameConvention());
            return serviceAction;
        }
    }
}
