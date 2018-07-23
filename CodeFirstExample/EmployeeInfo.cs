using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CodeFirstExample
{
    //POCO Classes
    //Plain Old CLR Objects
    class EmployeeInfo
    {
        [Key]//Primary Key in table
        public int EmpId { get; set; }
        [Required]//Not Null in table
        public string Name { get; set; }
        [Required]
        public string Dept { get; set; }
        [Required]
        [Range(minimum:10000,maximum:50000,ErrorMessage ="Salary Between 10000 to 50000")]
        public double Salary { get; set; }

    }
}
