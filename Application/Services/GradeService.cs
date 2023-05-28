using Application.Interfaces;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
	public class GradeService : IGradeService
	{
		private readonly IGradeRepository _repository;

		public GradeService(IGradeRepository repository)
		{
			_repository = repository;
		}
	}
}
