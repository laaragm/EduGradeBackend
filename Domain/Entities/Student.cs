using Domain.Common;

namespace Domain.Entities
{
    public class Student : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
		public string RegistrationNumber { get; set; } = string.Empty;

		// Navigation Properties
		public ICollection<Grade> Grades { get; set; } = null!;
    }
}