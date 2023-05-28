using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.DTOs;
using Presentation.Shared;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubjectsController : ControllerBase
	{
		private readonly ISubjectService _subjectService;

		public SubjectsController(ISubjectService subjectService)
		{
			_subjectService = subjectService;
		}

		// GET: api/subjects
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var result = await _subjectService.GetAllAsync();
			return Ok(RequestResponse.Success("Subjects retrieved successfully.", result));
		}

		// GET: api/subjects/1
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var result = await _subjectService.GetByIdAsync(id);
			if (result == null)
			{
				return NotFound(RequestResponse.Failure("Subject not found."));
			}

			return Ok(RequestResponse.Success("Subject retrieved successfully.", result));
		}

		// POST: api/subjects
		[HttpPost]
		public async Task<IActionResult> Post(CreateSubjectDTO dto)
		{
			await _subjectService.AddAsync(dto);
			return Ok(RequestResponse.Success("Subject created successfully."));
		}

		// PUT: api/subjects/1
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, UpdateSubjectDTO dto)
		{
			if (id != dto.Id)
			{
				return BadRequest(RequestResponse.Failure("Ids does not match."));
			}

			await _subjectService.UpdateAsync(dto);
			return NoContent();
		}

		// DELETE: api/subjects/1
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _subjectService.DeleteAsync(id);
			return NoContent();
		}
	}
}
