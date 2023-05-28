using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
	public interface ISubjectRepository
	{
		Task<Subject?> GetByIdAsync(int id);
		Task<IEnumerable<Subject>> GetAllAsync();
		Task AddAsync(Subject subject);
		Task UpdateAsync(Subject subject);
		Task DeleteAsync(Subject subject);
	}
}
