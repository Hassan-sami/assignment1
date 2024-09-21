using System;
using System.Collections.Generic;

namespace assignment6.context.entities
{
    public  class Topic
    {
        public Topic()
        {
            Courses = new HashSet<Course>();
        }

        public int TopId { get; set; }
        public string? TopName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
