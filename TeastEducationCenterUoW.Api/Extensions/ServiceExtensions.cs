﻿using Microsoft.Extensions.DependencyInjection;
using TestEducationCenterUoW.Data.IRepositories;
using TestEducationCenterUoW.Data.Repositories;
using TestEducationCenterUoW.Service.Interfaces;
using TestEducationCenterUoW.Service.Services;
using TestEducationUow.Service.Interfaces;
using TestEducationUow.Service.Services;

namespace TestEducationCenterUoW.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ITeacherService, TeacherService>();
        }
    }
}
