using Domain.Entities;

namespace Application.Interfaces
{
	public interface ITeacherService
	{
		Task<Teacher?> GetByIdAsync(int id);
		Task<IEnumerable<Teacher>> GetAllAsync();
		Task AddAsync(Teacher teacher);
		Task UpdateAsync(Teacher teacher);
		Task DeleteAsync(int id);
	}
}
