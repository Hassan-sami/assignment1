using assignment6.context;
using assignment6.context.entities;
using DAL.Repo.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.Implementation
{
    public class StudentRepo : IStudentRepo
    {
        private readonly RouteContext routeContext;
        private  bool disposed;
        public StudentRepo(RouteContext context) 
        {
            routeContext = context;
        }
        public void Add(Student student)
        {
            routeContext?.Students.Add(student);
            routeContext?.SaveChanges();
        }

        public void Delete(Student student)
        {
            routeContext?.Students.Remove(student);
            routeContext?.SaveChanges();
        }

        public Student GetStudent(int id)
        {
            var student = routeContext.Students.Find(id);
            if (student == null)
                return null;
            return student;

        }

        public void Update(Student student)
        {
            routeContext?.Students.Update(student);
            routeContext?.SaveChanges();
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
                routeContext.Dispose();
            }

            disposed = true;
        }

        public IEnumerable<Student> GetAll()
        {
            return routeContext.Students;
        }
    }
}
