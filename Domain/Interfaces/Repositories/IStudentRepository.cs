using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
	public interface IStudentRepository
	{
		Task<Student?> GetByIdAsync(int id);
		Task<IEnumerable<Student>> GetAllAsync();
		Task AddAsync(Student student);
		Task UpdateAsync(Student student);
		Task DeleteAsync(Student student);
	}
}
