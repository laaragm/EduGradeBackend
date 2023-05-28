using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.DTOs;
using Presentation.Shared;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GradesController : ControllerBase
	{
		private readonly IGradeService _gradeService;

		public GradesController(IGradeService gradeService)
		{
			_gradeService = gradeService;
		}

		// GET: api/grades
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var result = await _gradeService.GetAllAsync();
			return Ok(RequestResponse.Success("Subjects retrieved successfully.", result));
		}

		// GET: api/grades/1
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var result = await _gradeService.GetByIdAsync(id);
			if (result == null)
			{
				return NotFound(RequestResponse.Failure("Grade not found."));
			}

			return Ok(RequestResponse.Success("Grade retrieved successfully.", result));
		}

		// POST: api/grades
		[HttpPost]
		public async Task<IActionResult> Post(CreateGradeDTO dto)
		{
			await _gradeService.AddAsync(dto);
			return Ok(RequestResponse.Success("Grade created successfully."));
		}

		// PUT: api/grades/1
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, UpdateGradeDTO dto)
		{
			if (id != dto.Id)
			{
				return BadRequest(RequestResponse.Failure("Ids does not match."));
			}

			await _gradeService.UpdateAsync(dto);
			return NoContent();
		}

		// DELETE: api/grades/1
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _gradeService.DeleteAsync(id);
			return NoContent();
		}

		// GET: api/grades/student/2
		[HttpGet("student/{studentId}")]
		public async Task<IActionResult> GetGradesByStudentId(int studentId)
		{
			var grades = await _gradeService.GetByStudentIdAsync(studentId);

			if (grades == null || !grades.Any())
			{
				return NotFound(RequestResponse.Failure($"No grades found for student with id {studentId}."));
			}

			return Ok(RequestResponse.Success($"Grades retrieved successfully for student with id {studentId}.", grades));
		}

		// GET: api/grades/subject/3
		[HttpGet("subject/{subjectId}")]
		public async Task<IActionResult> GetGradesBySubjectId(int subjectId)
		{
			var grades = await _gradeService.GetBySubjectIdAsync(subjectId);

			if (grades == null || !grades.Any())
			{
				return NotFound(RequestResponse.Failure($"No grades found for student with id {subjectId}."));
			}

			return Ok(RequestResponse.Success($"Grades retrieved successfully for student with id {subjectId}.", grades));
		}
	}
}
