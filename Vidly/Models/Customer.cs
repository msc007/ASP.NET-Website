using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required] 
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }


        //[Display] will change html field 
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }     //byte type is implicit [Required]

        [Display(Name = "Date of Birth")]        
        [Min18YearsIfMamber]
        public DateTime? Birthdate { get; set; }
    }
}