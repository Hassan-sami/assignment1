using System;
using System.Collections.Generic;

namespace assignment6.context.entities
{
    public  class Instructor
    {
        public Instructor()
        {
            Departments = new HashSet<Department>();
            InsCourses = new HashSet<InsCourse>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Degree { get; set; }
        public decimal? Salary { get; set; }
        public int? DeptId { get; set; }

        public virtual Department? Dept { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<InsCourse> InsCourses { get; set; }
    }
}
