using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WTF_Site.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public bool IsSubscribedToEmail { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}