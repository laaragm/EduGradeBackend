using Application.DTOs;

namespace Application.Interfaces
{
	public interface ISubjectService
	{
		Task<SubjectDTO?> GetByIdAsync(int id);
		Task<IEnumerable<SubjectDTO>> GetAllAsync();
		Task AddAsync(CreateSubjectDTO subject);
		Task UpdateAsync(UpdateSubjectDTO subject);
		Task DeleteAsync(int id);
	}
}
