using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment6.context.entities;
using BLL.Services.Abstract;
using DAL.Repo.Abstract;
using DAL.Repo.Implementation;

namespace BLL.Services.Implementation
{
    public class StudnetService : IStudnetService
    {
        private readonly IStudentRepo studentRepo;
        private bool disposed;

        public StudnetService(IStudentRepo studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        public void Add(Student student)
        {
            studentRepo.Add(student);
        }

        public Student GetStudent(int id)
        {
            return studentRepo.GetStudent(id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return studentRepo.GetAll();  
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                studentRepo.Dispose();
            }

            disposed = true;
        }
    }
}
