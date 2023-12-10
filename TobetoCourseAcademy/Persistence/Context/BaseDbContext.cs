using System.Collections.Generic;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {

        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {

        }

        //public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        //{
        //    Configuration = configuration;
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=CourseAcademyDb;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate =True");
        }

        //protected IConfiguration Configuration { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
    }
}
