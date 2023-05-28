namespace Application.DTOs
{
	public class SimplifiedGradeDTO
	{
		public int Id { get; set; }
		public float Value { get; set; }
		public SimplifiedSubjectDTO Subject { get; set; } = null!;
	}

	public class GradeDTO
	{
		public int Id { get; set; }
		public float Value { get; set; }
		public SimplifiedSubjectDTO Subject { get; set; } = null!;
		public SimplifiedStudentDTO Student { get; set; } = null!;
}

	public class CreateGradeDTO
	{
		public int Id { get; set; }
		public int StudentId { get; set; }
		public int SubjectId { get; set; }
		public float Value { get; set; }
	}

	public class UpdateGradeDTO
	{
		public int Id { get; set; }
		public int StudentId { get; set; }
		public int SubjectId { get; set; }
		public float Value { get; set; }
	}
}
