using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
	public class TeacherService : ITeacherService
	{
		private readonly ITeacherRepository _repository;

		public TeacherService(ITeacherRepository repository)
		{
			_repository = repository;
		}

		public async Task<Teacher?> GetByIdAsync(int id)
		{
			return await _repository.GetByIdAsync(id);
		}

		public async Task<IEnumerable<Teacher>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task AddAsync(Teacher teacher)
		{
			await _repository.AddAsync(teacher);
		}

		public async Task UpdateAsync(Teacher teacher)
		{
			await _repository.UpdateAsync(teacher);
		}

		public async Task DeleteAsync(int id)
		{
			var teacher = await _repository.GetByIdAsync(id);
			if (teacher != null)
			{
				await _repository.DeleteAsync(teacher);
			}
		}
	}
}
