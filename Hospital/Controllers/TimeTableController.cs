using Hospital.Models;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Hospital.Controllers
{

    public class TimeTableController : Controller
    {
        private readonly AuthorizationContext context;
        public List<TimeTable> timeTables { get; set; }
        public UserManager<User> _userManager;

        public TimeTableController(AuthorizationContext authorizationContext, UserManager<User> userManager)
        {
            context = authorizationContext;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var table = context.TimeTables.ToList();
            List<TimeTableViewModel> timeTableViewModels = new List<TimeTableViewModel>();
            foreach (var item in table)
            {
                DoctorsViewModel doctorsView = new DoctorsViewModel()
                {
                    Id = item.DoctorId.Id,
                    User = context.Users.Where(x => x.Id == item.DoctorId.UserId).First(),
                    Specialty = context.DoctorSpecialties.Where(x => x.Id == item.DoctorId.SpecialtyId).First()
                };
                timeTableViewModels.Add(new TimeTableViewModel()
                {
                    Id = item.Id,
                    Doctors = doctorsView,
                    Monday = item.Monday,
                    Tuesday = item.Tuesday,
                    Thirsday = item.Thirsday,
                    Wednesday = item.Wednesday,
                    Friday = item.Friday
                });
            }
            string currentUserId = (await _userManager.GetUserAsync(HttpContext.User))?.Id;
            ViewBag.User = context.Users.Where(x => x.Id == currentUserId).First();

            return View(timeTableViewModels);
        }

        [Authorize(Roles = "Admin, Doctor ")]
        [HttpGet]
        public async Task<IActionResult> TableCreate(string userId)
        {
            Doctor doctor = context.Doctors.Where(x=> x.UserId==userId).First();
            DoctorsViewModel doctorsViewModel = new DoctorsViewModel();
            User user = context.Users.Where(x=>x.Id == userId).First();


            doctor.UserId = userId;
            if (context.Doctors.Any())
            {
                doctor.SpecialtyId = context.Doctors?.Where(x => x.UserId == userId)?.First().SpecialtyId;
                doctorsViewModel.Id = doctor.Id;
                doctorsViewModel.Specialty = context.DoctorSpecialties.Where(x => x.Id == doctor.SpecialtyId).First();
                doctorsViewModel.User = user;
            }

            var times = context.TimeTables.ToList();

            return View(doctorsViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> TableCreate(TimeTableViewModel model)
        {
            if (ModelState.IsValid)
            {
                TimeTable result = null;

                if (context.TimeTables.Any())
                {
                    result = context.TimeTables.Where(x => x.Id == model.Id)?.First();
                }

                var doctor = context.Doctors.Where(x => x.Id == model.Doctors.Id).First();

                if (result == null)
                {
                    TimeTable table = new TimeTable
                    {
                        Id = model.Id,
                        DoctorId = doctor,
                        Monday = model.Monday,
                        Tuesday = model.Tuesday,
                        Thirsday = model.Thirsday,
                        Wednesday = model.Wednesday,
                        Friday = model.Friday
                    };

                    await context.TimeTables.AddAsync(table);
                    await context.SaveChangesAsync();
                }
                else
                {
                    result.Id = model.Id;
                    result.DoctorId = doctor;
                    result.Monday = model.Monday;
                    result.Tuesday = model.Tuesday;
                    result.Thirsday = model.Thirsday;
                    result.Wednesday = model.Wednesday;
                    result.Friday = model.Friday;
                }
                return RedirectToAction("Index", "TimeTable");
            }
            else
            {
                return RedirectToAction("TableCreate", "TimeTable");
            }

           
        }
    }
}
