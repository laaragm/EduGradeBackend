using Application.Interfaces;
using Application.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			var assembly = typeof(DependencyInjection).Assembly;

			services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));

			services.AddValidatorsFromAssembly(assembly);

			services.AddScoped<ITeacherService, TeacherService>();
			services.AddScoped<IStudentService, StudentService>();
			services.AddScoped<ISubjectService, SubjectService>();
			services.AddScoped<IGradeService, GradeService>();

			return services;
		}
	}
}