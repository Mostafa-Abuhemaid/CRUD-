using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MVC_Project.DAL.Model
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage =" Name is Required")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = " Code is Required")]
        public string Code { get; set; }

        public DateTime datetime { get; set; }
        public ICollection<Employee> Employees { get; set; }= new HashSet<Employee>();
    }
}
