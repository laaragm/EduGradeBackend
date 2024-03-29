﻿using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.DTOs;
using Presentation.Shared;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TeachersController : ControllerBase
	{
		private readonly ITeacherService _teacherService;

		public TeachersController(ITeacherService teacherService)
		{
			_teacherService = teacherService;
		}

		// GET: api/teachers
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var result = await _teacherService.GetAllAsync();
			return Ok(RequestResponse.Success("Teachers retrieved successfully.", result));
		}

		// GET: api/teachers/1
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var result = await _teacherService.GetByIdAsync(id);
			if (result == null)
			{
				return NotFound(RequestResponse.Failure("Teacher not found."));
			}

			return Ok(RequestResponse.Success("Teacher retrieved successfully.", result));
		}

		// POST: api/teachers
		[HttpPost]
		public async Task<IActionResult> Post(CreateTeacherDTO dto)
		{
			await _teacherService.AddAsync(dto);
			return Ok(RequestResponse.Success("Teacher created successfully."));
		}

		// PATCH: api/teachers/1
		[HttpPatch("{id}")]
		public async Task<IActionResult> Patch(int id, UpdateTeacherDTO dto)
		{
			if (id != dto.Id)
			{
				return BadRequest(RequestResponse.Failure("Ids does not match."));
			}

			await _teacherService.UpdateAsync(dto);
			return NoContent();
		}

		// DELETE: api/teachers/1
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _teacherService.DeleteAsync(id);
			return NoContent();
		}
	}
}
