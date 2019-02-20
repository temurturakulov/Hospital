using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class AuthorizationContext:IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
        public DbSet<Authorization> Authorizations { get; set; }

        public AuthorizationContext(DbContextOptions<AuthorizationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
