using Application.Interfaces;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
	public class SubjectService : ISubjectService
	{
		private readonly ISubjectRepository _repository;

		public SubjectService(ISubjectRepository repository)
		{
			_repository = repository;
		}
	}
}
