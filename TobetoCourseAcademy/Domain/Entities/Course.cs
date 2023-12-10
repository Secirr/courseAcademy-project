using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class Course : Entity<Guid>
	{
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public List<CourseInstructor> CourseEducators { get; set; }
        public Category Category { get; set; }
    }
}

