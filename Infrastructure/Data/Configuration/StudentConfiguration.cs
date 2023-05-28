using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.ToTable("Students");
			builder.HasKey(x => x.Id).IsClustered();
			builder.Property(x => x.Name).HasColumnType("varchar(128)").IsRequired();
			builder.Property(x => x.Address).HasColumnType("varchar(256)").IsRequired();
			builder.Property(x => x.Email).HasColumnType("varchar(64)").IsRequired();
			builder.Property(x => x.PhoneNumber).HasColumnType("varchar(11)").IsRequired();
			builder.Property(x => x.RegistrationNumber).HasColumnType("varchar(32)").IsRequired();
		}
	}
}
