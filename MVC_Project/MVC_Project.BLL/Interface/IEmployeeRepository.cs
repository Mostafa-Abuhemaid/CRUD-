using MVC_Project.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC_Project.BLL.Interface
{
    public interface IEmployeeRepository : IGenericRepository<Employee> 

    {
        IQueryable<Employee> GetEmployeesByAdress(string adress);
    }
}
