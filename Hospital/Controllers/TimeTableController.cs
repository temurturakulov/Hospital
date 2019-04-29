using Hospital.Models;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Controllers
{
    
    public class TimeTableController : Controller
    {
        private readonly AuthorizationContext context;
        public List<TimeTable> timeTables { get; set; }
        public TimeTableController(AuthorizationContext authorizationContext)
        {
            context = authorizationContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var table = context.TimeTables.ToList();
            List<TimeTableViewModel> timeTableViewModels = new List<TimeTableViewModel>();
            foreach (var item in table)
            {
                DoctorsViewModel doctorsView = new DoctorsViewModel() {
                    Id = item.DoctorId.Id,
                    User = context.Users.Where(x => x.Id == item.DoctorId.UserId).First(),
                    Specialty = context.DoctorSpecialties.Where(x => x.Id == item.DoctorId.SpecialtyId).First()
                };
                timeTableViewModels.Add(new TimeTableViewModel() {
                    Id= item.Id,
                    Doctors=doctorsView,
                    Monday=item.Monday,
                    Tuesday=item.Tuesday,
                    Thirsday=item.Thirsday,
                    Wednesday=item.Wednesday,
                    Friday=item.Friday                  
                });
            }
            return View(timeTableViewModels);
        }
        [Authorize(Roles = "Admin, Doctor ")]
        [HttpGet]
        public async Task<IActionResult> TableCreate(User Id)
        {
            Doctor doctor = new Doctor();
            DoctorsViewModel doctorsViewModel = new DoctorsViewModel();            

            doctor.UserId = Id.Id;
            if (context.Doctors.Any())
            {
                doctor.SpecialtyId = context.Doctors?.Where(x => x.UserId == Id.Id)?.First().SpecialtyId;
                doctorsViewModel.Id = doctor.Id;
                doctorsViewModel.Specialty = context.DoctorSpecialties.Where(x => x.Id == doctor.Id).First();
                doctorsViewModel.User = Id;
            }

            var times = context.TimeTables.ToList();

            return View(doctorsViewModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> TableCreate(TimeTableViewModel model)
        {
            var result = context.TimeTables.Where(x => x.Id == model.Id).First();

            if (result == null)
            {
                TimeTable table = new TimeTable
                {
                    Id = model.Id,
                    DoctorId= model.DoctorId,                                      
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
                result.DoctorId = model.DoctorId;                                
                result.Monday = model.Monday;
                result.Tuesday = model.Tuesday;
                result.Thirsday = model.Thirsday;
                result.Wednesday = model.Wednesday;
                result.Friday = model.Friday;
            }
               return RedirectToAction("Index", "TimeTable");
        }
    }
}
