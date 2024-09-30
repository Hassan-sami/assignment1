using DAL.Repo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.Abstract;
using assignment6.context.entities;
using assignment6.context;

namespace BLL.Services.Implementation
{
    public class DepartmnetService : IDepartmentService
    {
        private readonly IDeptartmentRepo deptartmentRepo;

        private bool disposed;

        public DepartmnetService(IDeptartmentRepo deptartmentRepo)
        {
            this.deptartmentRepo = deptartmentRepo;
        }
        public IEnumerable<Department> GetDepartments()
        {
            return deptartmentRepo.GetAll();
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
                deptartmentRepo.Dispose();
            }

            disposed = true;
        }
    }
}
