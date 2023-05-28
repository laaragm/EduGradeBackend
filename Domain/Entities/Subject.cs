using Domain.Common;

namespace Domain.Entities
{
    public class Subject : IEntity
	{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
		public int TeacherId { get; set; }

        // Navigation Properties
        public Teacher? Teacher { get; set; }
        public ICollection<Grade> Grades { get; set; } = null!;
    }
}
