using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Controllers
{
    public class Specialty:Controller
    {
        private readonly AuthorizationContext _context;
        public List<DoctorSpecialty> doctorSpecialties { get; set; }
        public Specialty(AuthorizationContext db)
        {
            _context = db;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var Specialities = _context.DoctorSpecialties.ToList();
            return View(Specialities);
        }

        [HttpPost]
        public async Task<IActionResult> SpecialtyCreate(string specialtyName)
        {
            if (!string.IsNullOrEmpty(specialtyName))
            {
                var result = await _context.DoctorSpecialties.AddAsync(new DoctorSpecialty() {Name=specialtyName });
                //if(result!=null)
                //{
                    return RedirectToAction("SpecialtyCreate", "Specialty");
                //}
                
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> specialtyCreate()
        {
            var Specialities = _context.DoctorSpecialties.ToList();
            return View();
        }
    }
}
