using Microsoft.Extensions.DependencyInjection;
using Presentation.Controllers;

namespace Presentation
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddPresentation(this IServiceCollection services)
		{
			services.AddScoped<TeachersController>();

			return services;
		}
	}
}