using System;
using System.Collections.Generic;

namespace assignment6.context.entities
{
    public  class Department
    {
        public Department()
        {
            Instructors = new HashSet<Instructor>();
            Students = new HashSet<Student>();
        }

        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        public string? DeptDesc { get; set; }
        public string? DeptLocation { get; set; }
        public int? DeptManagerId { get; set; }
        public DateTime? ManagerHiredate { get; set; }

        public virtual Instructor? DeptManager { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
