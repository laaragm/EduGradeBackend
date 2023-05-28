using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class SubjectRepository : ISubjectRepository
	{
		private readonly EduGradeDbContext _context;

		public SubjectRepository(EduGradeDbContext context)
		{
			_context = context;
		}

		public async Task<Subject?> GetByIdAsync(int id)
		{
			return await _context.Subjects
				.Include(x => x.Teacher)
				.FirstAsync(x => x.Id == id);
		}

		public async Task<IEnumerable<Subject>> GetAllAsync()
		{
			return await _context.Subjects.Include(x => x.Teacher).ToListAsync();
		}

		public async Task AddAsync(Subject subject)
		{
			await _context.Subjects.AddAsync(subject);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Subject subject)
		{
			_context.Subjects.Update(subject);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(Subject subject)
		{
			_context.Subjects.Remove(subject);
			await _context.SaveChangesAsync();
		}
	}
}
