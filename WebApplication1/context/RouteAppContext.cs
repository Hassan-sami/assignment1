using System;
using System.Collections.Generic;
using assignment6.context.enitityRelation;
using assignment6.context.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace assignment6.context
{
    public partial class RouteAppContext : DbContext
    {
        public RouteAppContext()
        {
        }

        public RouteAppContext(DbContextOptions<RouteAppContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<InsCourse> InsCourses { get; set; } = null!;
        public virtual DbSet<Instructor> Instructors { get; set; } = null!;
        public virtual DbSet<StudCourse> StudCourses { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;        
        public virtual DbSet<Topic> Topics { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseModel).Assembly);

        }

        
    }
}
