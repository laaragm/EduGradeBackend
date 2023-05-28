using Application.DTOs;

namespace Application.Interfaces
{
	public interface IStudentService
	{
		Task<StudentDTO?> GetByIdAsync(int id);
		Task<IEnumerable<StudentDTO>> GetAllAsync();
		Task AddAsync(CreateStudentDTO student);
		Task UpdateAsync(UpdateStudentDTO student);
		Task DeleteAsync(int id);
	}
}
