using MVC_Project.BLL.Interface;
using MVC_Project.DAL.Context;
using MVC_Project.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC_Project.BLL.Repository
{
    public class EmployeeRepository :GenericRepository<Employee>, IEmployeeRepository 
    {
        private readonly MVCdbContext _dbcontext;

        public EmployeeRepository(MVCdbContext dbcontext):base(dbcontext) 
        {
            _dbcontext = dbcontext;
        }
        public IQueryable<Employee> GetEmployeesByAdress(string adress)
        {
            return _dbcontext.employees.Where(e => e.Adrress == adress);
        }

    }
}
