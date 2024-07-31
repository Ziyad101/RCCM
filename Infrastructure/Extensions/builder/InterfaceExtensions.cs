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
            services.AddScoped<IRoleRepo, RoleRepo>();
            services.AddScoped<IRequestRepo, RequestRepo>();
            services.AddScoped<ICandidateRepo, CandidateRepo>();
            services.AddScoped<IMajorRepo, MajorRepo>();
            services.AddScoped<INationalityRepo, NationalityRepo>();
            services.AddScoped<ICandidateStatusRepo, CandidateStatusRepo>();
            services.AddScoped<IExamTypeConfRepo, ExamTypeConfRepo>();
            services.AddScoped<IExamResultRepo, ExamResultRepo>();
            services.AddScoped<IInterviewRepo, InterviewRepo>();
            services.AddScoped<ICreatorExamTypeConfRepo, CreatorExamTypeConfRepo>();
            services.AddScoped<IExperienceRepo, ExperienceRepo>();





            return services;
        }


    }
}
