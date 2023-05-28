using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Configuration
{
	public class MapperConfig : Profile
	{
		public MapperConfig()
		{
			CreateMap<Grade, GradeDTO>().ReverseMap();
			CreateMap<Grade, UpdateGradeDTO>().ReverseMap();
			CreateMap<Grade, CreateGradeDTO>();

			CreateMap<Teacher, TeacherDTO>().ReverseMap();
			CreateMap<Teacher, UpdateTeacherDTO>().ReverseMap();
			CreateMap<Teacher, CreateTeacherDTO>();

			CreateMap<Student, StudentDTO>().ReverseMap();
			CreateMap<Student, UpdateStudentDTO>().ReverseMap();
			CreateMap<Student, CreateStudentDTO>();

			CreateMap<Subject, SubjectDTO>().ReverseMap();
			CreateMap<Subject, UpdateSubjectDTO>().ReverseMap();
			CreateMap<Subject, CreateSubjectDTO>();
		}
	}
}
