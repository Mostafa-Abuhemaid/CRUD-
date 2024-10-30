using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVC_Project.DAL.Model
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The name is required")]
        [MaxLength(50,ErrorMessage ="Max length is 50")]
        [MinLength(5,ErrorMessage ="Min length is 5")]
        public string Name { get; set; }
        [Range(22,35,ErrorMessage ="the age must be in range 22 and 35")]
        public int? Age { get; set; }
        [RegularExpression("^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}$",
           ErrorMessage ="the address must be like 123-street-City-Country" ) ]
        public string Adrress { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }

        public DateTime HireTime { get; set; }
        public DateTime CreationDate{ get; set; }= DateTime.Now;

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; } //optional
        public Department Department { get; set; }
    }
}
