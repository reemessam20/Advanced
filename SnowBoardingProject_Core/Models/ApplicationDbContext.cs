using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Cinema_Core_Project.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        

        public ApplicationDbContext()
            : base()
        {
            
        }                

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}