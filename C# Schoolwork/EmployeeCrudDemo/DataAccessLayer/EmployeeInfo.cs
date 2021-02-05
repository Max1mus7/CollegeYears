using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class EmployeeInfo
    {
        public int EmployeeID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "First & LastName")]
        [Required(ErrorMessage = "Please enter your first and last name.")]
        public string Name { get; set; }


        [DataType(DataType.Text)]
        [Display(Name = "What is your gender?")]
        [Required(ErrorMessage = "Please enter your gender.")]
        public string Gender { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Please enter the company name.")]
        public string Company { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Department")]
        [Required(ErrorMessage = "Please enter your department name.")]
        public string Department { get; set; }
    }
}
