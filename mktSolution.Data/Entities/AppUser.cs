using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.Entities
{
   public class AppUser: IdentityUser<Guid>
    {
        public string Ecode { set; get; }
        public string Dept { set; get; }

        //public List<SCM_Order> SCM_Orders { set; get; }
        //public List<SCM_Product> SCM_Products { set; get; }
    }
}
