using Domain.Entities;

namespace Application.Interfaces
{
	public interface IStudentService
	{
		Task<Student?> GetByIdAsync(int id);
		Task<IEnumerable<Student>> GetAllAsync();
		Task AddAsync(Student student);
		Task UpdateAsync(Student student);
		Task DeleteAsync(int id);
	}
}
