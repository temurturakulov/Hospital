using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class TimeTable
    {
        public int Id { get; set; }
        public Doctor DoctorId { get; set; }
        //public User User { get; set; }
        //public DoctorSpecialty Specialty { get; set; }
        public DateTime Monday { get; set; }
        public DateTime Tuesday { get; set; }
        public DateTime Thirsday { get; set; }
        public DateTime Wednesday { get; set; }
        public DateTime Friday { get; set; }

    }
}
