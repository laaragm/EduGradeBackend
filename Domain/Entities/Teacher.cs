using Domain.Common;

namespace Domain.Entities
{
    public class Teacher : IEntity
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Cpf { get; set; }
        public string? ExpertiseAreas { get; set; }

        // Navigation Properties
        public ICollection<Subject> Subjects { get; set; }
    }
}
