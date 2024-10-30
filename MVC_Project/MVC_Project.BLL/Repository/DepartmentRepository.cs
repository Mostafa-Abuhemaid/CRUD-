using MVC_Project.BLL.Interface;
using MVC_Project.DAL.Context;
using MVC_Project.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC_Project.BLL.Repository
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly MVCdbContext _dbcontext;

        public DepartmentRepository(MVCdbContext dbcontext):base(dbcontext) 
        {
         _dbcontext = dbcontext;
        }
  
    }
}
