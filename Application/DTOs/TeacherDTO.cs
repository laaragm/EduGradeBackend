namespace Application.DTOs
{
	public class SimplifiedTeacherDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
	}

	public class TeacherDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Cpf { get; set; } = string.Empty;
		public string ExpertiseAreas { get; set; } = string.Empty;
		public IList<SimplifiedSubjectDTO> Subjects { get; set; } = null!;
	}

	public class CreateTeacherDTO
	{
		public string Name { get; set; } = string.Empty;
		public string Cpf { get; set; } = string.Empty;
		public string ExpertiseAreas { get; set; } = string.Empty;
	}

	public class UpdateTeacherDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Cpf { get; set; } = string.Empty;
		public string ExpertiseAreas { get; set; } = string.Empty;
	}
}
