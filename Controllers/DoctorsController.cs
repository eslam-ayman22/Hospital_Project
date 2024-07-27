using Hospital.Data;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class DoctorsController : Controller
    {

        ApplicationDbContext context = new ApplicationDbContext();

      
        public IActionResult BookAppiontment()
        {
            var result = context.doctors.ToList();
            return View(result);
        }

        

        public IActionResult CompleteAppiontment(int id)
        {
            var name = context.doctors.Find(id);
            return View(name);
        }
       

        public IActionResult savenew(Patient patient)
        {
            context.patients.Add(patient);
            context.SaveChanges();

            return RedirectToAction("BookAppiontment");
        }

        




    }
}
