

using Core.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions.builder
{
    public static class InterfaceExtensions
    {
        public static IServiceCollection Interfaces(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IHomeRepo, HomeRepo>();
            services.AddScoped<IUserRepo, UserRepo>();

            return services;
        }


    }
}
