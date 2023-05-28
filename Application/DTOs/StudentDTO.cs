namespace Application.DTOs
{
	public class SimplifiedStudentDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
	}

	public class StudentDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
		public string RegistrationNumber { get; set; } = string.Empty;
		public IList<SimplifiedGradeDTO> Grades { get; set; } = null!;
	}

	public class CreateStudentDTO
	{
		public string Name { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
		public string RegistrationNumber { get; set; } = string.Empty;
	}

	public class UpdateStudentDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
		public string RegistrationNumber { get; set; } = string.Empty;
	}
}
