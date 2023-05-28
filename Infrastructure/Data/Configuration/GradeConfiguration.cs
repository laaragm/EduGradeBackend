using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data.Configuration
{
	public class GradeConfiguration : IEntityTypeConfiguration<Grade>
	{
		public void Configure(EntityTypeBuilder<Grade> builder)
		{
			builder.ToTable("Grades");
			builder.HasKey(x => x.Id).IsClustered();
			builder.Property(x => x.Value).HasColumnType("decimal(3,2)").IsRequired();

			builder.HasOne(g => g.Student)
				.WithMany(s => s.Grades)
				.HasForeignKey(g => g.StudentId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(g => g.Subject)
				.WithMany(s => s.Grades)
				.HasForeignKey(g => g.SubjectId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
