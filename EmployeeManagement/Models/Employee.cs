using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a value for Name field")]
        public string Name { get; set; }

        [Display(Name = "User Id")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        [Required]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }
        // public string PhotoPath { get; set; }

        [Display(Name = "Invited On")]
        [DataType(DataType.Date)]
        public DateTime InvitedOn { get; set; }

        [Display(Name = "Last Active")]
        [DataType(DataType.Date)]
        public DateTime LastActive { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
