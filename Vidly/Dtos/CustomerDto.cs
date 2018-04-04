using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }


        //public MembershipType MembershipType { get; set; }   for security issue

        public byte MembershipTypeId { get; set; }     //byte type is implicit [Required]

        //[Min18YearsIfMamber]
        public DateTime? Birthdate { get; set; }
    }
}