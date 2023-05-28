using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Configuration
{
	public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
	{
		public void Configure(EntityTypeBuilder<Teacher> builder)
		{
			builder.ToTable("Teachers");
			builder.HasKey(x => x.Id).IsClustered();
			builder.Property(x => x.Name).HasColumnType("varchar(128)").IsRequired();
			builder.Property(x => x.ExpertiseAreas).HasColumnType("varchar(512)").IsRequired();
			builder.Property(x => x.Cpf).HasColumnType("varchar(11)").IsRequired();
		}
	}
}
