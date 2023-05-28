using Application.DTOs;

namespace Application.Interfaces
{
	public interface ITeacherService
	{
		Task<TeacherDTO?> GetByIdAsync(int id);
		Task<IEnumerable<TeacherDTO>> GetAllAsync();
		Task AddAsync(CreateTeacherDTO teacher);
		Task UpdateAsync(UpdateTeacherDTO teacher);
		Task DeleteAsync(int id);
	}
}
