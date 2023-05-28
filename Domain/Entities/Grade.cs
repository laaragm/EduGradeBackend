using Domain.Common;

namespace Domain.Entities
{
    public class Grade : IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal Value { get; set; }

        // Navigation Properties
        public Subject Subject { get; set; } = null!;
        public Student Student { get; set; } = null!;
    }
}
