using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
	public class StudentService : IStudentService
	{
		private readonly IStudentRepository _repository;

		public StudentService(IStudentRepository repository)
		{
			_repository = repository;
		}

		public async Task<Student?> GetByIdAsync(int id)
		{
			return await _repository.GetByIdAsync(id);
		}

		public async Task<IEnumerable<Student>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task AddAsync(Student student)
		{
			await _repository.AddAsync(student);
		}

		public async Task UpdateAsync(Student student)
		{
			await _repository.UpdateAsync(student);
		}

		public async Task DeleteAsync(int id)
		{
			var student = await _repository.GetByIdAsync(id);
			if (student != null)
			{
				await _repository.DeleteAsync(student);
			}
		}
	}
}
