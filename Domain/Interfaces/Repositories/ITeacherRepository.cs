using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
	public interface ITeacherRepository
	{
		Task<Teacher?> GetByIdAsync(int id);
		Task<IEnumerable<Teacher>> GetAllAsync();
		Task AddAsync(Teacher teacher);
		Task UpdateAsync(Teacher teacher);
		Task DeleteAsync(Teacher teacher);
	}
}
