using assignment6.context.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.Abstract
{
    public interface IDeptartmentRepo
    {
        IEnumerable<Department> GetAll();
        public void Dispose();

    }
}
