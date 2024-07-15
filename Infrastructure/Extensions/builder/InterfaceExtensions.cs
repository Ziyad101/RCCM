

using Core.Interfaces;


using Core.Interfaces.ServiceInterfaces;

using Infrastructure.Repositories;
using Infrastructure.Services;
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
            services.AddScoped<IRoleRepo, RoleRepo>();

            services.AddScoped<INationalityRepo, NationalityRepo>();


            ////Services
            services.AddScoped<IDemoService, DemoServices>();


            return services;
        }


    }
}
