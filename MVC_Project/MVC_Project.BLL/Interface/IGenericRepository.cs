using MVC_Project.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC_Project.BLL.Interface
{
    public interface IGenericRepository <T> 
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Add(T item);
        int Update(T item);
        int Delete(T item);
        IQueryable<Employee> GetEmployeesByAdress(string adress);
    }
}
