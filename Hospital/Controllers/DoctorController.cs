using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospital.Models;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AuthorizationContext context;
        RoleManager<IdentityRole> _roleManager;
        UserManager<User> _userManager;
        public List<Doctor> doctors { get; set; }


        public DoctorController(
            AuthorizationContext authorizationContext, 
            RoleManager<IdentityRole> roleManager, 
            UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            context = authorizationContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var doctors = context.Doctors.ToList();
            List<DoctorsViewModel> doctorsViewModels = new List<DoctorsViewModel>();

            foreach(var item in doctors)
            {
                doctorsViewModels.Add(
                    new DoctorsViewModel() {
                        Specialty= context.DoctorSpecialties.Where(x=>x.Id== item.SpecialtyId).First(),
                        User = context.Users.Where(x=> x.Id == item.UserId).First()

                    });
            }
            
            
            return View(doctorsViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var roleId = context.Roles.Where(x=> x.Name=="Doctor").First().Id;
            var doctors = (from c in context.UserRoles
                          from b in context.Users
                          where c.RoleId == roleId
                          && c.UserId == b.Id select b).ToList();

            var speciality = context.DoctorSpecialties.Select(x => x).ToList();
            ViewBag.DoctorSpecialty = speciality;

            return View(doctors);
        }

        [HttpPost]
        public async Task<IActionResult> Create(int? doctorSpecialty, string userId)
        {
            var roleId = context.Roles.Where(x => x.Name == "Doctor").First().Id;
            var doctors = (from c in context.UserRoles
                           from b in context.Users
                           where c.RoleId == roleId
                           && c.UserId == b.Id
                           select b).ToList();
            

            if (doctorSpecialty != null && userId != null)
            {
                var user = context.Users.Where(x => x.Id == userId).First();
                var specialty = context.DoctorSpecialties.Where(x => x.Id == doctorSpecialty).First();

                var isDoctorPresent = context.Doctors.Any(x=> x.UserId == user.Id);

                if (isDoctorPresent)
                {
                    var doctor = context.Doctors.Where(x => x.UserId == user.Id).First();
                    doctor.SpecialtyId = specialty.Id;
                }
                else
                {
                    await context.Doctors.AddAsync(new Doctor()
                    {
                        UserId = user.Id,
                        SpecialtyId = specialty.Id
                    });
                }
                
                await context.SaveChangesAsync();
            }
            return RedirectToAction("Create");
        }
    }
}