﻿using assignment6.context.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstract
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetDepartments();
    }

}
