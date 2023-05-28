using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
	public class SubjectService : ISubjectService
	{
		private readonly ISubjectRepository _repository;
		private readonly IMapper _mapper;

		public SubjectService(ISubjectRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<SubjectDTO?> GetByIdAsync(int id)
		{
			var student = await _repository.GetByIdAsync(id);
			if (student != null)
			{
				var result = _mapper.Map<SubjectDTO>(student);
				return result;
			}

			return null;
		}

		public async Task<IEnumerable<SubjectDTO>> GetAllAsync()
		{
			var subjects = await _repository.GetAllAsync();
			var result = subjects.Select(_mapper.Map<SubjectDTO>);
			return result;
		}

		public async Task AddAsync(CreateSubjectDTO dto)
		{
			var subject = _mapper.Map<Subject>(dto);
			await _repository.AddAsync(subject);
		}

		public async Task UpdateAsync(UpdateSubjectDTO dto)
		{
			var subject = _mapper.Map<Subject>(dto);
			await _repository.UpdateAsync(subject);
		}

		public async Task DeleteAsync(int id)
		{
			var subject = await _repository.GetByIdAsync(id);
			if (subject != null)
			{
				await _repository.DeleteAsync(subject);
			}
		}
	}
}
