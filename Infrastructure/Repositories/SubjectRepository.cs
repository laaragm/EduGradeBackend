using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
	public class SubjectRepository : ISubjectRepository
	{
		private readonly EduGradeDbContext _context;

		public SubjectRepository(EduGradeDbContext context)
		{
			_context = context;
		}
	}
}
