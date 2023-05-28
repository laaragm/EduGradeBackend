using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
	public class StudentService : IStudentService
	{
		private readonly IStudentRepository _repository;
		private readonly IMapper _mapper;

		public StudentService(IStudentRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<StudentDTO?> GetByIdAsync(int id)
		{
			var student = await _repository.GetByIdAsync(id);
			if (student == null)
			{
				var result = _mapper.Map<StudentDTO>(student);
				return result;
			}

			return null;
		}

		public async Task<IEnumerable<StudentDTO>> GetAllAsync()
		{
			var students = await _repository.GetAllAsync();
			var result = students.Select(_mapper.Map<StudentDTO>);
			return result;
		}

		public async Task AddAsync(CreateStudentDTO dto)
		{
			var student = _mapper.Map<Student>(dto);
			await _repository.AddAsync(student);
		}

		public async Task UpdateAsync(UpdateStudentDTO dto)
		{
			var student = _mapper.Map<Student>(dto);
			await _repository.UpdateAsync(student);
		}

		public async Task DeleteAsync(int id)
		{
			var student = await _repository.GetByIdAsync(id);
			if (student != null)
			{
				await _repository.DeleteAsync(student);
			}
		}
	}
}
