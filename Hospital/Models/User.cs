using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class User:IdentityUser
    {
        
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }       
        public Authorization AuthId { get; set; }
    }
}
