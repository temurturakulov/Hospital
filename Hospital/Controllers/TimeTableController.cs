﻿using Hospital.Models;
using Hospital.ViewModels;
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
            var Table = context.TimeTables.ToList();
            //ViewBag.Specialty = context.DoctorSpecialties.ToList();
            //var Specialties = context.DoctorSpecialties.ToList();
             
            // ViewBag.User = context.Users.ToList();
            return View(Table);
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
                    
                    UserId = model.UserId,
                    SpecialtyId = model.SpecialtyId,
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
                result.UserId = model.UserId;
                result.SpecialtyId = model.SpecialtyId;
                result.Monday = model.Monday;
                result.Tuesday = model.Tuesday;
                result.Thirsday = model.Thirsday;
                result.Wednesday = model.Wednesday;
                result.Friday = model.Friday;
            }
               return RedirectToAction("TableCreate", "TimeTableController");
        }
    }
}