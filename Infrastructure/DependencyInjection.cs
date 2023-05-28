using Domain.Interfaces.Repositories;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services)
		{
			services.AddScoped<ITeacherRepository, TeacherRepository>();
			services.AddScoped<IStudentRepository, StudentRepository>();
			services.AddScoped<ISubjectRepository, SubjectRepository>();
			services.AddScoped<IGradeRepository, GradeRepository>();

			return services;
		}
	}
}