using Application.DTOs;

namespace Application.Interfaces
{
	public interface IGradeService
	{
		Task<GradeDTO?> GetByIdAsync(int id);
		Task<IDictionary<int, IList<GradeDTO>>> GetAllAsync();
		Task AddAsync(CreateGradeDTO grade);
		Task UpdateAsync(UpdateGradeDTO grade);
		Task DeleteAsync(int id);
	}
}
