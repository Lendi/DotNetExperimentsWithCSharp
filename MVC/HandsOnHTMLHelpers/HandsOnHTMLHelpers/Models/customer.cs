using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//library for validating model data
using System.ComponentModel;//ditto as above

namespace HandsOnHTMLHelpers.Models
{
    public class customer
    {
        [Required(ErrorMessage="Pls enter ID")]
        [Display(Name="CustomerId")]    
        public int cid { get; set; }
        [Required(ErrorMessage = "Pls enter customer name")]
        [Display(Name = "CustomerName")]   
        public string cname { get; set; }
        [StringLength(30, ErrorMessage="Address between 10 to 30 chars", MinimumLength=10)]
        public string address { get; set; }
        public string country { get; set; }
        public string JoinDate { get; set; }
    }
}