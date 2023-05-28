namespace Application.DTOs
{
	public class SimplifiedSubjectDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
	}

	public class SubjectDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int TeacherId { get; set; }
		public IList<SimplifiedGradeDTO> Grades { get; set; } = null!;
	}

	public class CreateSubjectDTO
	{
		public string Name { get; set; } = string.Empty;
		public int TeacherId { get; set; }
	}

	public class UpdateSubjectDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int TeacherId { get; set; }
	}
}
