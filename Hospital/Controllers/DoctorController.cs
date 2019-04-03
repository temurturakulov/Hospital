using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospital.Models;
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
            var doctor = context.Doctors.ToList();
            return View(doctor);
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
        public async Task<IActionResult> Create(DoctorSpecialty doctorSpecialty, User userId)
        {
            if (doctorSpecialty != null && userId != null)
            {
                await context.Doctors.AddAsync(new Doctor()
                {
                    UserId = userId,
                    SpecialtyId = doctorSpecialty
                });
            }
            

            return View();
        }
    }
}