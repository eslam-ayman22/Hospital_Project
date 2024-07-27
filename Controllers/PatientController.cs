using Hospital.Data;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Hospital.Controllers
{
    public class PatientController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IActionResult Index()
        {
            
          var result=  context.patients.ToList();
            return View(result);
        }

    }
}
