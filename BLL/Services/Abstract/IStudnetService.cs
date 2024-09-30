using assignment6.context.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstract
{
    public interface IStudnetService
    {
        Student GetStudent(int id);
        void Add(Student student);
        IEnumerable<Student> GetStudents();
    }
}
