using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Configuration
{
	public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
	{
		public void Configure(EntityTypeBuilder<Subject> builder)
		{
			builder.ToTable("Subjects");
			builder.HasKey(x => x.Id).IsClustered();
			builder.Property(x => x.Name).HasColumnType("varchar(128)").IsRequired();

			builder.HasOne(s => s.Teacher)
				.WithMany(t => t.Subjects)
				.HasForeignKey(s => s.TeacherId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
