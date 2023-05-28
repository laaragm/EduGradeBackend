using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain.Entities;

namespace Infrastructure.Data
{
	public class EduGradeDbContext : DbContext
    {
		private readonly IConfiguration _configuration;
		public virtual DbSet<Teacher> Teachers { get; set; } = null!;
		public virtual DbSet<Student> Students { get; set; } = null!;
		public virtual DbSet<Subject> Subjects { get; set; } = null!;
		public virtual DbSet<Grade> Grades { get; set; } = null!;

		public EduGradeDbContext(DbContextOptions<EduGradeDbContext> options, IConfiguration configuration) : base(options)
		{
			_configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var connection = new SqlConnection();
			connection.ConnectionString = _configuration.GetConnectionString("DbConnectionString");

			// Use the options builder parameter to inform which provider you'll be using
			optionsBuilder.UseSqlServer(connection);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(EduGradeDbContext).Assembly);
		}
	}
}
