using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
	public class GradeRepository : IGradeRepository
	{
		private readonly EduGradeDbContext _context;

		public GradeRepository(EduGradeDbContext context)
		{
			_context = context;
		}
	}
}
