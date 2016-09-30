using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//library for validating model data
using System.ComponentModel;//ditto as above

namespace HandsOnHTMLHelpers.Models
{
    public class Employee
    {
        [Required(ErrorMessage="ID Required") ]
        [Display(Name="Employee ID")]
        public int Eid { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(100, MinimumLength=3, ErrorMessage="Minimum 3 chars")]    
        [Display(Name = "Employee Name")]
        public string Ename { get; set; }


        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter Valid Email Address")]
        public string Email { get; set; }

        [RegularExpression("[7-9]{1}[0-9]{9}", ErrorMessage="Invalid Mobile Number")]
        public string Mobile { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Enter join date")]
        public DateTime JoinDate { get; set; }
        
        [DataType(DataType.Currency)]
        [Range(10000,20000,ErrorMessage="Between 10000 to 20000")]
        public double Salary { get; set; }
        
        [Required(ErrorMessage="Username is Required") ]
        [Display(Name="Username")]
        public string Uname { get; set; }

        [Required(ErrorMessage="Password is Required") ]
        [Display(Name="Password")]
        [DataType(DataType.Password)]
        [RegularExpression("[a-z0-9A-Z@#$%]{6,8}", ErrorMessage="Allow only 6-8 alpha numeric characters")]
        public string Pwd { get; set; }



    }
}