using MVC_Project.BLL.Interface;
using MVC_Project.DAL.Context;
using MVC_Project.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC_Project.BLL.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MVCdbContext _dbcontext;

        public GenericRepository(MVCdbContext dbcontext)
        {
         _dbcontext = dbcontext;
        }
        public int Add(T item)
        {
           _dbcontext.Add(item);
            return _dbcontext.SaveChanges();
        }

        public int Delete(T item)
        {
           _dbcontext.Remove(item);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
          return  _dbcontext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
           return _dbcontext.Set<T>().Find(id);
        }

        public int Update(T item)
        {
           _dbcontext.Update(item);
            return _dbcontext.SaveChanges();
        }

        IQueryable<Employee> IGenericRepository<T>.GetEmployeesByAdress(string adress)
        {
            throw new NotImplementedException();
        }
    }
}
