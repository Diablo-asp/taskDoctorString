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
        public IActionResult BookAppointment(FillteringVM Fi)
        {
            IQueryable<Doctor> doctors = _context.Doctors;
            
            // Fillter
            if (Fi.Name is not null)
            {
                doctors = doctors.Where(e => e.Name.Contains(Fi.Name));                              
            }
            //if (Fi.Specialization is not null)
            //{
            //    doctors = doctors.Where(e => e.Specialization.Contains(Fi.Specialization));
            //}
            if(Fi.DoctorId > 0 & Fi.DoctorId <= doctors.Count())
            {
                doctors = doctors.Where(e=>e.Id ==  Fi.DoctorId);
               
            }
            return View(doctors.ToList());
        }
        [HttpGet]
        public IActionResult DoctorForm(int Id)
        {
            var doctor = _context.Doctors.FirstOrDefault(e => e.Id == Id);           
            return View(doctor);
        }
        [HttpPost] 
        public IActionResult DoctorForm(DoctorForm FFD)
        {
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
