using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskTopProj
{
    public class ApplicationUser : IdentityUser
    {
        //[Required]
        //[StringLength(50)]
        //public string FirstName { get; set; }

        //[Required]
        //[StringLength(50)]
        //public string LastName { get; set; }
    }
    public class ApplicationRole : IdentityRole
    {
        //[Required]
        //[StringLength(50)]
        //public string ProperName { get; set; }
    }

    public class MyIdentityDb : IdentityDbContext<ApplicationUser>
    {
        public MyIdentityDb()

        : base("ShopDBConnectionString")
        {

        }
    }
}
