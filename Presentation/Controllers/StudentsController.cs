using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.DTOs;
using Presentation.Shared;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private readonly IStudentService _studentService;

		public StudentsController(IStudentService studentService)
		{
			_studentService = studentService;
		}

		// GET: api/students
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var result = await _studentService.GetAllAsync();
			return Ok(RequestResponse.Success("Students retrieved successfully.", result));
		}

		// GET: api/students/1
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var result = await _studentService.GetByIdAsync(id);
			if (result == null)
			{
				return NotFound(RequestResponse.Failure("Student not found."));
			}

			return Ok(RequestResponse.Success("Student retrieved successfully.", result));
		}

		// POST: api/students
		[HttpPost]
		public async Task<IActionResult> Post(CreateStudentDTO dto)
		{
			await _studentService.AddAsync(dto);
			return Ok(RequestResponse.Success("Student created successfully."));
		}

		// PUT: api/students/1
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, UpdateStudentDTO dto)
		{
			if (id != dto.Id)
			{
				return BadRequest(RequestResponse.Failure("Ids does not match."));
			}

			await _studentService.UpdateAsync(dto);
			return NoContent();
		}

		// DELETE: api/students/1
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _studentService.DeleteAsync(id);
			return NoContent();
		}
	}
}
