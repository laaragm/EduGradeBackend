using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
	public interface IGradeRepository
	{
		Task<Grade?> GetByIdAsync(int id);
		Task<IEnumerable<Grade>> GetAllAsync();
		Task AddAsync(Grade grade);
		Task UpdateAsync(Grade grade);
		Task DeleteAsync(Grade grade);
	}
}
