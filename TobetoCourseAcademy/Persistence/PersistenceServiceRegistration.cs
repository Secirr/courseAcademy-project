﻿using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CourseAcademyConnectionString")));


            services.AddScoped<ICategoryRepository, CategoryRepository>();

            //services.AddScoped<ICourseRepository, CourseRepository>();

            return services;
        }
    }

    //public static class PersistenceServiceRegistration
    //{
    //    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    //    {

    //        //services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CourseAcademyConnectionString")));

    //        //services.AddDbContext<BaseDbContext>(options => options.UseInMemoryDatabase("CourseAcademyDb"));
    //        //services.AddScoped<ICourseRepository, CourseRepository>();
    //        //services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CourseAcademyConnectionString"))); //1
    //        services.AddScoped<ICategoryRepository, CategoryRepository>();

    //        return services;
    //    }
    //}
}