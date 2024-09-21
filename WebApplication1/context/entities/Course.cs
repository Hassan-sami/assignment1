using System;
using System.Collections.Generic;

namespace assignment6.context.entities
{
    public class Course
    {
        public Course()
        {
            InsCourses = new HashSet<InsCourse>();
            StudCourses = new HashSet<StudCourse>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Duration { get; set; }
        public int? TopicId { get; set; }

        public virtual Topic? Topic { get; set; }
        public virtual ICollection<InsCourse> InsCourses { get; set; }
        public virtual ICollection<StudCourse> StudCourses { get; set; }
    }
}
