using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class StudentRepository : IStudentRepository
	{
		private readonly EduGradeDbContext _context;

		public StudentRepository(EduGradeDbContext context)
		{
			_context = context;
		}

		public async Task<Student?> GetByIdAsync(int id)
		{
			return await _context.Students.FindAsync(id);
		}

		public async Task<IEnumerable<Student>> GetAllAsync()
		{
			return await _context.Students.ToListAsync();
		}

		public async Task AddAsync(Student student)
		{
			await _context.Students.AddAsync(student);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Student student)
		{
			_context.Students.Update(student);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(Student student)
		{
			_context.Students.Remove(student);
			await _context.SaveChangesAsync();
		}
	}
}
