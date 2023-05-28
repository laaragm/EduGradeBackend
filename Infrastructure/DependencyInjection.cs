using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<EduGradeDbContext>(options =>
			options.UseSqlServer(
				configuration.GetConnectionString("DbConnectionString"),
				x => x.MigrationsAssembly(typeof(EduGradeDbContext).Assembly.FullName)));

			services.AddScoped<ITeacherRepository, TeacherRepository>();
			services.AddScoped<IStudentRepository, StudentRepository>();
			services.AddScoped<ISubjectRepository, SubjectRepository>();
			services.AddScoped<IGradeRepository, GradeRepository>();

			return services;
		}
	}
}