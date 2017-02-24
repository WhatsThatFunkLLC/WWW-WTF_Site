using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WTF_Site.Models;

namespace WTF_Site.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}