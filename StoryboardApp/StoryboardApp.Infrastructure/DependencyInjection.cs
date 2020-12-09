using Microsoft.Extensions.DependencyInjection;
using StoryboardApp.Application.Interfaces;
using StoryboardApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryboardApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IStoryRepository, StoryRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
