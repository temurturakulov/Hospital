using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public User UserId { get; set; }
        public DoctorSpecialty SpecialtyId { get; set; }
    }
}
