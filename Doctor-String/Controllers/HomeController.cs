using System.Diagnostics;
using System.Linq;
using Doctor_String.Data;
using Doctor_String.Models;
using Doctor_String.ViewModels;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Doctor_String.Controllers
{    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context = new();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookAppointment(FillteringVM Fi, int page =1)
        {
            IQueryable<Doctor> doctors = _context.Doctors;
            const double totalNumberOfDoctorsPages = 8.0;

            // Fillter
            if (Fi.Name is not null)
            {
                doctors = doctors.Where(e => e.Name.Contains(Fi.Name)); 
                ViewData["Name"] = Fi.Name; 
            }
            if (Fi.Specialization is not null)
            {
                doctors = doctors.Where(e => e.Specialization.Contains(Fi.Specialization));
                ViewData["Specialization"] = Fi.Specialization;
            }
            //if(Fi.DoctorId > 0 && Fi.DoctorId <= doctors.Count())
            //{
            //    doctors = doctors.Where(e=>e.Specialization == Fi.Specialization);
            //    ViewData["DoctorID"] = Fi.DoctorId;

            //}

            //pageination
            var totalNumberOfPages = Math.Ceiling(doctors.Count() / totalNumberOfDoctorsPages);

            if (totalNumberOfPages < page)
                return NotFound();

            doctors = doctors.Skip((page - 1) * (int)totalNumberOfDoctorsPages).Take((int)totalNumberOfDoctorsPages);

            ViewBag.TotalNumberOfPages = totalNumberOfPages;
            ViewBag.currentPage = page;


            return View(doctors.ToList());
        }
        [HttpGet]        public IActionResult DoctorForm(int Id)
        {
            var doctor = _context.Doctors.FirstOrDefault(e => e.Id == Id);           
            return View(doctor);
        }
        [HttpPost]
        public IActionResult DoctorForm(DoctorForm FFD)
        {
            var doctor = _context.Doctors.FirstOrDefault(d => d.Id == FFD.DoctorId);
            if (doctor == null)
                return NotFound();

            var appointments = _context.DoctorForms
                .Where(f => f.DoctorId == FFD.DoctorId && f.DayAppointment == FFD.DayAppointment)
                .OrderBy(f => f.TimeAppoint)
                .ToList();

            TimeOnly nextTime = doctor.StartWork;
            bool found = false;

            while (nextTime <= doctor.EndWork)
            {
                if (!appointments.Any(a => a.TimeAppoint == nextTime))
                {
                    found = true;
                    break;
                }

                nextTime = nextTime.AddMinutes(15);
            }
            if (!found)
            {
                ModelState.AddModelError(string.Empty, "لا يوجد مواعيد متاحة في هذا اليوم.");
                return View(doctor);
            }


            _context.DoctorForms.Add(FFD);
            _context.SaveChanges();

            return RedirectToAction("FormDone");
        }

        public IActionResult FormDone()
        {
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
