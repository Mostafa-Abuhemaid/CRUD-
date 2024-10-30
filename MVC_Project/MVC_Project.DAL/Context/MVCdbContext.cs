using Microsoft.EntityFrameworkCore;
using MVC_Project.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Project.DAL.Context
{
    public class MVCdbContext : DbContext
    {
        public MVCdbContext(DbContextOptions<MVCdbContext>options):base(options) 
        {
        
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=MVC_Project;Trusted_Connection=True");
        //}
       public  DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}
