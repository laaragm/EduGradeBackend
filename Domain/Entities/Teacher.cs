using Domain.Common;

namespace Domain.Entities
{
    public class Teacher : IEntity
	{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
		public string Cpf { get; set; } = string.Empty;
		public string ExpertiseAreas { get; set; } = string.Empty;

		// Navigation Properties
		public ICollection<Subject> Subjects { get; set; } = null!;
    }
}
