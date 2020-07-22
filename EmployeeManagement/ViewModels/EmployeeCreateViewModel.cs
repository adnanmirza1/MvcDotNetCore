using EmployeeManagement.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeCreateViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }

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