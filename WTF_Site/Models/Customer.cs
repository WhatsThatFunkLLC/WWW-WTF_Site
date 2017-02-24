using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WTF_Site.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public bool IsSubscribedToEmail { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name="Membership Type")]
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Date of birth:")]
        public DateTime? Birthdate { get; set; }
    }
}