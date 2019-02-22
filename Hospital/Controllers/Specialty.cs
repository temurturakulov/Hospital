using Hospital.Models;
using Hospital.ViewModels;
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
                 await _context.DoctorSpecialties.AddAsync(new DoctorSpecialty() {Name=specialtyName });
                await _context.SaveChangesAsync();
                    return RedirectToAction("SpecialtyCreate", "Specialty");
                
                
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> specialtyCreate()
        {
            var Specialities = _context.DoctorSpecialties.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SpecialtyDelete(int id)
        {
            
            DoctorSpecialty doctor = _context.DoctorSpecialties.Where(x => x.Id == id).First();
            if (doctor!=null)
            {
                _context.DoctorSpecialties.Remove(doctor);
                await _context.SaveChangesAsync();
            }
               
            return RedirectToAction("Index", "Specialty");
            
        }

        [HttpPost]
        public async Task<IActionResult> SpecialtyEdit(SpecialtyViewModel specialty)
        {
            DoctorSpecialty doctor = _context.DoctorSpecialties.Where(x => x.Id == specialty.Id).First();
            if (doctor != null)
            {
                doctor.Name = specialty.Name;
               await _context.SaveChangesAsync();
                var result = _context.DoctorSpecialties.ToList();
                return View("Index", result);
            }
            return RedirectToAction("Index", "Specialty");
        }

        [HttpGet]
        public async Task<IActionResult> SpecialtyEdit(int id)
        {
            DoctorSpecialty doctor = _context.DoctorSpecialties.Where(x => x.Id == id).First();
            return View("Edit" ,new SpecialtyViewModel(){Id=doctor.Id, Name=doctor.Name });

        }
    }
}
