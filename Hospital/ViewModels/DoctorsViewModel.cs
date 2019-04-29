using Hospital.Models;

namespace Hospital.ViewModels
{
    public class DoctorsViewModel
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DoctorSpecialty Specialty { get; set; }
    }
}
