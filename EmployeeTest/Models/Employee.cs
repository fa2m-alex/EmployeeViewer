using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeTest.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Birthday")]
        public DateTime Birthday { get; set; }

        public int? HeadID { get; set; }
        public virtual Employee Head { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}