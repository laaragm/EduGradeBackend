using Domain.Common;

namespace Domain.Entities
{
    public class Student : IEntity
	{
		public int Id { get; set; }
		public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? RegistrationNumber { get; set; }

        // Navigation Properties
        public ICollection<Grade> Grades { get; set; }
    }
}