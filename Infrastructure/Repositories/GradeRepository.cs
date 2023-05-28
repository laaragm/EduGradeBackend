using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Infrastructure.Repositories
{
	public class GradeRepository : IGradeRepository
	{
		private readonly EduGradeDbContext _context;

		public GradeRepository(EduGradeDbContext context)
		{
			_context = context;
		}

		public async Task<Grade?> GetByIdAsync(int id)
		{
			return await _context.Grades
				.Include(x => x.Subject)
				.Include(x => x.Student)
				.FirstAsync(x => x.Id == id);
		}

		public async Task<IEnumerable<Grade>> GetAllAsync()
		{
			return await _context.Grades
				.Include(x => x.Subject)
				.Include(x => x.Student)
				.ToListAsync();
		}

		public async Task AddAsync(Grade grade)
		{
			await _context.Grades.AddAsync(grade);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Grade grade)
		{
			_context.Grades.Update(grade);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(Grade grade)
		{
			_context.Grades.Remove(grade);
			await _context.SaveChangesAsync();
		}
	}
}
