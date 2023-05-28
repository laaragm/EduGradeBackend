using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class TeacherRepository : ITeacherRepository
	{
		private readonly EduGradeDbContext _context;

		public TeacherRepository(EduGradeDbContext context)
		{
			_context = context;
		}

		public async Task<Teacher?> GetByIdAsync(int id)
		{
			return await _context.Teachers.FindAsync(id);
		}

		public async Task<IEnumerable<Teacher>> GetAllAsync()
		{
			return await _context.Teachers.ToListAsync();
		}

		public async Task AddAsync(Teacher teacher)
		{
			await _context.Teachers.AddAsync(teacher);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Teacher teacher)
		{
			_context.Teachers.Update(teacher);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(Teacher teacher)
		{
			_context.Teachers.Remove(teacher);
			await _context.SaveChangesAsync();
		}
	}
}
