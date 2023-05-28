using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data
{
	public class EduGradeDbContextFactory : IDesignTimeDbContextFactory<EduGradeDbContext>
	{
		public EduGradeDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<EduGradeDbContext>();
			optionsBuilder.UseSqlServer();

			var config = new ConfigurationBuilder().Build();

			return new EduGradeDbContext(optionsBuilder.Options, config);
		}
	}
}
