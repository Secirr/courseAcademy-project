using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class Instructor : Entity<Guid>
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

        public string Description { get; set; }

		public List<CourseInstructor> CourseInstructors { get; set; }
	}
}

