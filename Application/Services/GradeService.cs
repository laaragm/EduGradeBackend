using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
	public class GradeService : IGradeService
	{
		private readonly IGradeRepository _repository;
		private readonly IMapper _mapper;

		public GradeService(IGradeRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<GradeDTO?> GetByIdAsync(int id)
		{
			var grade = await _repository.GetByIdAsync(id);
			if (grade != null)
			{
				var result = _mapper.Map<GradeDTO>(grade);
				return result;
			}

			return null;
		}

		public async Task<IDictionary<int, IList<GradeDTO>>> GetAllAsync()
		{
			var grades = await _repository.GetAllAsync();
			var result = new Dictionary<int, IList<GradeDTO>>();
			foreach (var grade in grades)
			{
				var keyExists = result.ContainsKey(grade.StudentId);
				if (!keyExists)
					result[grade.StudentId] = new List<GradeDTO>();
				result[grade.StudentId].Add(_mapper.Map<GradeDTO>(grade));
			}

			return result;
		}

		public async Task AddAsync(CreateGradeDTO dto)
		{
			var grade = _mapper.Map<Grade>(dto);
			await _repository.AddAsync(grade);
		}

		public async Task UpdateAsync(UpdateGradeDTO dto)
		{
			var grade = _mapper.Map<Grade>(dto);
			await _repository.UpdateAsync(grade);
		}

		public async Task DeleteAsync(int id)
		{
			var grade = await _repository.GetByIdAsync(id);
			if (grade != null)
			{
				await _repository.DeleteAsync(grade);
			}
		}

		public async Task<IEnumerable<GradeDTO>> GetBySubjectIdAsync(int subjectId)
		{
			var result = await _repository.GetBySubjectIdAsync(subjectId);
			return result.Select(_mapper.Map<GradeDTO>);
		}

		public async Task<IEnumerable<GradeDTO>> GetByStudentIdAsync(int studentId)
		{
			var result = await _repository.GetByStudentIdAsync(studentId);
			return result.Select(_mapper.Map<GradeDTO>);
		}
	}
}
