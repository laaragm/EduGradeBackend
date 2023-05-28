using Application.Configuration;
using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(MapperConfig));

			services.AddScoped<ITeacherService, TeacherService>();
			services.AddScoped<IStudentService, StudentService>();
			services.AddScoped<ISubjectService, SubjectService>();
			services.AddScoped<IGradeService, GradeService>();

			return services;
		}
	}
}