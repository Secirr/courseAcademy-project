using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class CourseInstructor : Entity<Guid>
	{
		public Guid CourseId { get; set; }

		public Guid InstructorId { get; set; }

		public Course course { get; set; }

		public Instructor instructor { get; set; }

		
	}
}

