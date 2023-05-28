using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
	public class TeacherService : ITeacherService
	{
		private readonly ITeacherRepository _repository;
		private readonly IMapper _mapper;

		public TeacherService(ITeacherRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<TeacherDTO?> GetByIdAsync(int id)
		{
			var teacher = await _repository.GetByIdAsync(id);
			if (teacher != null)
			{
				var result = _mapper.Map<TeacherDTO>(teacher);
				return result;
			}

			return null;
		}

		public async Task<IEnumerable<TeacherDTO>> GetAllAsync()
		{
			var teachers = await _repository.GetAllAsync();
			var result = teachers.Select(_mapper.Map<TeacherDTO>);
			return result;
		}

		public async Task AddAsync(CreateTeacherDTO dto)
		{
			var teacher = _mapper.Map<Teacher>(dto);
			await _repository.AddAsync(teacher);
		}

		public async Task UpdateAsync(UpdateTeacherDTO dto)
		{
			var teacher = _mapper.Map<Teacher>(dto);
			await _repository.UpdateAsync(teacher);
		}

		public async Task DeleteAsync(int id)
		{
			var teacher = await _repository.GetByIdAsync(id);
			if (teacher != null)
			{
				await _repository.DeleteAsync(teacher);
			}
		}
	}
}
