using assignment6.context.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.Abstract
{
    public interface IStudentRepo
    {
        public void Add(Student student);

        public void Update(Student student);

        public void Delete(Student student);

        public Student GetStudent(int id);

        public IEnumerable<Student> GetAll();

        public void Dispose();

    }
}
