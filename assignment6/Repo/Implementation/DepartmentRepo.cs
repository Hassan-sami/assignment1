using assignment6.context;
using assignment6.context.entities;
using DAL.Repo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.Implementation
{
    public class DepartmentRepo : IDeptartmentRepo
    {
        private readonly RouteContext routeContext;
        private bool disposed;

        public DepartmentRepo(RouteContext routeContext)
        {
            this.routeContext = routeContext;
        }
        public IEnumerable<Department> GetAll()
        {
           return routeContext.Departments;
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
    }
}
