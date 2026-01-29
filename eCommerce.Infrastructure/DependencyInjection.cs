using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Infrastructure
{
    public static class DependencyInjection
    {
        /// <summary>
        /// extension method to add infrastructure services to the dependecny injection container
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Todo: Add infrastructure services to the Ioc container
            // for example : data access , caching and other low level componenets

            services.AddTransient<IUsersRepository, UsersRepository>();

            services.AddTransient<DapperDbContext>();

            return services;
        }
    }
}
