using Application.DTOs;

namespace Application.Interfaces
{
	public interface IGradeService
	{
		Task<GradeDTO?> GetByIdAsync(int id);
		Task<IEnumerable<GradeDTO>> GetAllAsync();
		Task<IEnumerable<GradeDTO>> GetBySubjectIdAsync(int subjectId);
		Task<IEnumerable<GradeDTO>> GetByStudentIdAsync(int studentId);
		Task AddAsync(CreateGradeDTO grade);
		Task UpdateAsync(UpdateGradeDTO grade);
		Task DeleteAsync(int id);
	}
}
