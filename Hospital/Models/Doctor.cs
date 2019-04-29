using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? SpecialtyId { get; set; }
    }
}
