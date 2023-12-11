using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Context
{
    public class BaseDbContext : DbContext
    {

        public BaseDbContext(DbContextOptions<BaseDbContext>options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=AAA;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate =True");
        }

        //protected IConfiguration Configuration { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }

    }

}





//public class BaseDbContext : DbContext
//{

//    public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
//    {

//    }

//    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    //{
//    //    optionsBuilder.UseSqlServer("Server=localhost,1433;Database=AAA;User Id=SA;Password=reallyStrongPwd123;Trusted_Connection=True;TrustServerCertificate=True");
//    //}


//    public DbSet<Category> Categories { get; set; }
//    //public DbSet<Course> Courses { get; set; }
//    //public DbSet<Instructor> Instructors { get; set; }
//    //public DbSet<CourseInstructors> CourseInstructors { get; set; }

//}