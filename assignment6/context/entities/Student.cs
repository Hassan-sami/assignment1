using System;
using System.Collections.Generic;

namespace assignment6.context.entities
{
    public  class Student
    {
        public Student()
        {
            Students = new HashSet<Student>();
            StudCourses = new HashSet<StudCourse>();
        }

        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }
        public int? DeptId { get; set; }
        public int? StSuperId { get; set; }

        public virtual Department? Dept { get; set; }
        public virtual Student? StSuper { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<StudCourse> StudCourses { get; set; }
    }
}
